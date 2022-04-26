using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSamples
{
    /// <summary>
    /// Подлежит расчету 
    /// </summary>
    public interface ICalculateSalary
    {
        /// <summary>
        /// Расчет среднемесячной заработной платы
        /// </summary>
        /// <returns></returns>
        abstract decimal СalculateSalary();
    }
}
