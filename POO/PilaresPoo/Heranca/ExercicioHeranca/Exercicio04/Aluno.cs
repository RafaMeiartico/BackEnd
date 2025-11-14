namespace ExercicioHeranca
{
    public class Aluno : Pessoa
    {

        public string Curso;
        public void exibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }
}