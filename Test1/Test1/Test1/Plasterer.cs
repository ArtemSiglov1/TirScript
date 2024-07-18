using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// класс описывающий штукатурщика
    /// </summary>
    internal class Plasterer : Staff
    { 
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Plasterer() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="typeOFWorker">тип рабочего</param>
        
        public Plasterer(string name, TypeWorker typeOFWorker) : base(name, typeOFWorker)
        {
            
        }
        /// <summary>
        /// метод для вывода инфы об объекте
        /// </summary>
        /// <returns>свойства базового класса </returns>
        public override string ToString()
        {
            return $"{base.ToString()}\n";
        }
        /// <summary>
        /// метод для ввода инфы об объекте 
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Plasterer Init()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            TypeWorker typeWorker = TypeWorker.Plasterer;
            return new Plasterer(name, typeWorker);
        }
    }
}
