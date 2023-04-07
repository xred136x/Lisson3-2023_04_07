using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisson3_2023_04_07
{
    internal class Program
    {
        static List<Person> Ask_N_Times(int n)
        {
            //List<Person> ans = new List<Person>();
            var ans = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        }
        static Person CreatePerson()
        {
            string name;
            int age = 0;
            Console.WriteLine("введите имя");
            name = Console.ReadLine();
        
            do 
            {
                try
                {
                    Console.WriteLine("введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("возраст не корректен");
                }
            }while (age <= 0 && age > 120);
            var person = new Person(name);
            person.Age = age;
            return person;
        }
        static void Main(string[] args)
        {
            /* Person person = new Person("Tom Johnes");
              person.Age = 21;
              person.Print();*/
            /* var _list = new List<Person>();
            var person = CreatePerson();
             _list.Add(person);
             _list[0].Print();*/

            var PersonList = Ask_N_Times(3);
            //PersonList.Sort();
            foreach(Person person in PersonList)
            {
                Console.WriteLine($"имя:{person.Name}, " + $"возраст:{person.Age}");
            }
        }
    }
}
