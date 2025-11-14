namespace ExercicioHeranca
{
    public class Gerente : Funcionario
    {

        public float Bonus;
        public override float CalcularSalario()
        {//retonra salário base + bonus
            return SalarioBase = +Bonus;
        }
    }
}