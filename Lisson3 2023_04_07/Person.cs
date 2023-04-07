using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisson3_2023_04_07
{
    internal class Person
    {
        private string _Name;
        //private int _Age;
        public string Name { /*set;*/ get { return _Name; } }
        public int Age { get; set; }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name} Возраст: {Age} год");
        }
        public Person(string Name)
        {
            _Name = Name;   
        }
        /*private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set 
            {
                if (value % 2 == 0)
                {
                    myVar = value;
                }
                else
                {
                    myVar = 0;
                }
                
            }
        }*/

    }
}
