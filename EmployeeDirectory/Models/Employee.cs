using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory.Models
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

    }
}
