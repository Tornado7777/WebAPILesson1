using System;

namespace SingletonSamples
{

    public class LazySingleton
    {

        // Lazy<T> - Обеспечивает поддержку отложенной инициализации.
        private static readonly Lazy<LazySingleton> _instance =
            new Lazy<LazySingleton>(() => new LazySingleton());


        public string Info1 {
            get { return "Info1"; }
        }

        public string Info2
        {
            get { return "Info2"; }
        }

        public LazySingleton() { }

        public static LazySingleton Instance
        {
            get { return _instance.Value; } 
            // Отложенная инициализация производится при первом обращении к свойству Lazy<T>.Value
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LazySingleton obj1 = LazySingleton.Instance;
            LazySingleton obj2 = LazySingleton.Instance;
            Console.WriteLine(obj1.Equals(obj2));


            Console.WriteLine("\n***\n");

            Console.WriteLine(obj1.Info1);
            Console.WriteLine(obj1.Info2);

            Console.ReadKey(true);
        }
    }
}
