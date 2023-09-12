using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //internal class Person
    //{
    //    public string name;
    //    public int age;
    //    public Person(string name, int age) // определение конструктора
    //    {
    //        this.name = name;
    //        this.age = age;

    //    }


    //    public void Print()
    //    {
    //        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    //    }
    //    public void Deconstruct(out string personName, out int personAge)
    //    {
    //        personName = name;
    //        personAge = age;
    //    }
    //}



















    internal class phone
    {

        public int number;
        public string model = "Неизвестна";
        public int weight;
        public string name = "Неизвестно";

        public phone(int n, string m, int w) { number = n; model = m; weight = w; }
        public phone(int nu, string mo) { number = nu; model = mo; }
        public phone() { }


        public void Print() => Console.WriteLine($"номер: {number} модель: {model} вес: {weight} ");

        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public void receiveCall(string name, int number)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void getNumber()
        {
            Console.WriteLine(number);
        }

        internal void Deconstruct(out int phoneNumber, out string phonenModel)
        {
            phoneNumber = number;
            phonenModel = model;
        }


    }
}


