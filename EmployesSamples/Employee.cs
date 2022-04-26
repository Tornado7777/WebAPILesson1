namespace EmployeesSamples
{
    /// <summary>
    /// Работник (базовый класс)
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Имя
        /// </summary>
        protected string Name { get; set; }
        
        /// <summary>
        /// Фамилия
        /// </summary>
        protected string Surname { get; set; }

        /// <summary>
        /// Ставка заработной платы
        /// </summary>
        protected decimal Salary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="salary">Ставка заработной платы</param>
        protected Employee(string name, string surname, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }

    struct MyStruct
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
