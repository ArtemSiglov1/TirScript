using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// класс описывающий сотрудников
    /// </summary>
    internal class Staff
    {
        /// <summary>
        /// Свойство имени
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство типа работника
        /// </summary>
        public TypeWorker TypeOfWorker { get; set; }
       
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Staff() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя рабочего</param>
        /// <param name="typeOFWorker">тип рабочего</param>
        /// <param name="exp">стаж рабочего</param>
        public Staff(string name,TypeWorker typeOFWorker)
        {
            Name = name;
            TypeOfWorker = typeOFWorker;
            
        }
        /// <summary>
        /// метод для вывода информации о сотруднике
        /// </summary>
        /// <returns>свойства класса</returns>
        public override string ToString()
        {
            return $"Имя-{Name}\tПрофессия-{TypeOfWorker}";
        }

    }
}
