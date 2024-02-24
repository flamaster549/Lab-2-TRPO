using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс сотрудник
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        private string lastName;
        /// <summary>
        /// Имя
        /// </summary>
        private string firstName;
        /// <summary>
        /// Отчество
        /// </summary>
        private string patronymicName;
        /// <summary>
        /// Ссылка на должность
        /// </summary>
        private Speciality speciality;

        /// <summary>
        /// Конструктор принимающий следующие аргументы 
        /// (все аргументы должны быть записаны в поля, если дата не задана, 
        /// то берется текущая дата)
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymicName">Отчество</param>
        /// <param name="shiftLink">Ссылка на должность</param>
        public Employee(string lastName, string firstName, string patronymicName, string shiftLink)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymicName = patronymicName;
            this.speciality = new Speciality();
        }
    }
}
