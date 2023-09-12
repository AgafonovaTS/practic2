using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class animal
    {
        public string name;
        private int age;
        public string voice;

        public void SetAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Недопустимый возраст");
            }
        }
    }
}
