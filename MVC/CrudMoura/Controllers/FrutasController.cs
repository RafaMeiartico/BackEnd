using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public List<Frutas> ListaDeFrutas = new List<Frutas>
        {
            new Frutas{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Frutas{Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Frutas{Id = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Cítrica"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.Frutas = ListaDeFrutas;
            return View();
        }

        //Mostra a tela de Cadastrar
        public IActionResult Create()
        {
            return View();
        }

        //Salva a fruta na lista de frutas
        //em seguida, redireciona para a lista/tela de ListarFrutas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SalvarFruta(Frutas frutaCadastrada)
        {
            //criar um id novo
            frutaCadastrada.Id = ListaDeFrutas.Max(f => f.Id) + 1;
            //salvar os dados da fruta na listaDeFrutas
            ListaDeFrutas.Add(frutaCadastrada);
            //voltar para a tela de listagem de frutas
            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}