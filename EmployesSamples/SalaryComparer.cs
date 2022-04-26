using System.Collections.Generic;

namespace EmployeesSamples
{
    /// <summary>
    /// Класс сравнения заработных плат работников
    /// </summary>
    public class SalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return ((ICalculateSalary)x).СalculateSalary() > ((ICalculateSalary)y).СalculateSalary() ? 1 : -1 ;
        }
    }
}
