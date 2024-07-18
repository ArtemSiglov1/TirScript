using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// класс описывающий сварщика
    /// </summary>
    internal class Welder : Staff
    {
        /// <summary>
        /// стаж
        /// </summary>
        public int Exp { get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Welder() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="typeOFWorker">тип рабочего</param>
        /// <param name="exp">стаж</param>
        public Welder(string name, TypeWorker typeOFWorker, int exp) : base(name, typeOFWorker)
        {
            Exp = exp;
        }
        /// <summary>
        /// метод для вывода инфы об объекте
        /// </summary>
        /// <returns>свойства базового класса и класса наследника</returns>
        public override string ToString()
        {
            return $"{base.ToString()}\tСтаж-{Exp}\n";
        }
        /// <summary>
        /// метод для ввода инфы об объекте 
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Welder Init()
        {
            string name = Console.ReadLine();
            TypeWorker typeWorker = TypeWorker.Welder;
            int exp=int.Parse(Console.ReadLine());
            return new Welder(name, typeWorker,exp);
        }
    }
}
