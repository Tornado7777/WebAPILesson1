using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSamples
{
    /// <summary>
    /// Рабочий (фулл-тайм)
    /// </summary>
    public class Worker : Employee, ICalculateSalary
    {
        public Worker(string name, string surname, decimal salary) : base(name, surname, salary) { }


        public decimal СalculateSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{Surname} {Name}; Рабочий; Среднемесячная заработная плата (фиксированная месячная оплата): {СalculateSalary()} (руб.)";
        }

    }
}
