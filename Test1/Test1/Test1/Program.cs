using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// перечисление типов рабочих
    /// </summary>
    enum TypeWorker
    {
        Tiler = 0,
        Plasterer = 1,
        Welder = 2,
        Architect = 3
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Staff> staffs = new List<Staff>();
            int y;
            Console.WriteLine("Колличество рабочих?");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Выбери тип работника");
                foreach (var k in Enum.GetValues(typeof(TypeWorker))) {
                    Console.WriteLine($"{(int)k}\t{k}");
                }
                y = int.Parse((Console.ReadLine()));
                staffs.Add(Worker(y));
            }
            Console.Clear();
            foreach (Staff staff in staffs )
            {
                Console.WriteLine(staff.ToString());
            }
        Console.ReadLine();
        }
        /// <summary>
        /// метод для выбора типа рабочего
        /// </summary>
        /// <param name="i">номер типа рабочего</param>
        /// <returns>тип рабочего</returns>
        public static Staff Worker(int i)
        {
            switch ((TypeWorker)i)
            {
                case TypeWorker.Tiler: return Tiller.Init();
                case TypeWorker.Plasterer:return  Plasterer.Init(); 
                case TypeWorker.Welder: return Welder.Init();
                case TypeWorker.Architect:  return Architect.Init();
                default: return null;
            }
        }
    }
}
