using System;

namespace EmployeesSamples
{
    class Program
    {
        
        #region Help methods and fields

        private static Random random = new Random();
        
        static Employee GenerateEmployee()
        {
            var names = new[] { "Анатолий", "Глеб", "Клим", "Мартин", "Лазарь", "Владлен", "Клим", "Панкратий", "Рубен", "Герман" };
            var surnames = new[] { "Григорьев", "Фокин", "Шестаков", "Хохлов", "Шубин", "Бирюков", "Копылов", "Горбунов", "Лыткин", "Соколов" };

            var typeIndex = random.Next(0, 2);
            var salary = random.Next(200, 501);
            var salaryIndex = random.Next(100, 160);
            switch (typeIndex)
            {
                case 0:
                    return new Freelancer(names[random.Next(0, 10)], surnames[random.Next(0, 10)], salary);
                case 1:
                    return new Worker(names[random.Next(0, 10)], surnames[random.Next(0, 10)], salary * salaryIndex);
            }
            return null;
        }

        #endregion

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            for (int i = 0; i < employees.Length; i++)
                employees[i] = GenerateEmployee();

            foreach (var employee in employees)
                Console.WriteLine(employee);

            Console.WriteLine();
            Array.Sort(employees, new SalaryComparer());

            Console.WriteLine("\n*** Отсортированный массив сотрудников ***\n");
            foreach (var employee in employees)
                Console.WriteLine(employee);

            Console.ReadKey();
        }
    }
}
