using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// класс описывающий архитектора
    /// </summary>
    internal class Architect : Staff
    {   
        /// <summary>
        /// кол-во выполненых проектов 
        /// </summary>
        public int CountProject { get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Architect() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="typeOFWorker">тип рабочего</param>
        /// <param name="countProject">кол-во проектов</param>
        public Architect(string name,TypeWorker typeOFWorker,int countProject):base(name,typeOFWorker)
        {
            CountProject = countProject;
        }
        /// <summary>
        /// метод для вывода инфы об объекте
        /// </summary>
        /// <returns>свойства базового класса и класса наследника</returns>
        public override string ToString()
        {
            return $"{base.ToString()}\tКолличество проектов-{CountProject}\n";
        }
        /// <summary>
        /// метод для ввода инфы об объекте 
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Architect Init()
        {
            string name = Console.ReadLine();
            TypeWorker typeWorker = TypeWorker.Architect;
            int countProject = int.Parse(Console.ReadLine());
            return new Architect(name, typeWorker, countProject);
        }
    }
}
