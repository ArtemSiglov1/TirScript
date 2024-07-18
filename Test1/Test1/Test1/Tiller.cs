using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// класс описывающий плиточника
    /// </summary>
    internal class Tiller:Staff
    {
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Tiller() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="typeOFWorker">тип рабочего</param>
        public Tiller(string name, TypeWorker typeOFWorker) : base(name, typeOFWorker){}
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
        public static Tiller Init()
        {
            Console.WriteLine("Введите имя");
            string name=Console.ReadLine();
            TypeWorker typeWorker = TypeWorker.Tiler;
            return new Tiller(name,typeWorker);
        }
    }
}
