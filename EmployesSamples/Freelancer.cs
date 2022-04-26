namespace EmployeesSamples
{
    /// <summary>
    /// Фрилансер (работник с почасовой оплатой)
    /// </summary>
    public class Freelancer : Employee, ICalculateSalary
    {
        public Freelancer(string name, string surname, decimal salary) : base(name, surname, salary) { }

        public decimal СalculateSalary()
        {
            return (decimal)20.8 * 8 * Salary;
        }

        public override string ToString()
        {
            return $"{Surname} {Name}; Фрилансер; Среднемесячная заработная плата: {СalculateSalary()} (руб.); Почасовая ставка: {Salary} (руб.)";
        }

    }
}
