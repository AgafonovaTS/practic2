using ConsoleApp1;

//Person tom = new Person();          // вызов 1-ого конструктора без параметров
//Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
//Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

//tom.Print();          // Имя: Неизвестно  Возраст: 18
//bob.Print();          // Имя: Bob  Возраст: 18
//sam.Print();          // Имя: Sam  Возраст: 25
//Person person = new Person("Tom", 33);

//(string name, int age) = person;

//Console.WriteLine(name);    // Tom
//Console.WriteLine(age);     // 33

//class Person
//{
//    public string name;
//    public int age;
//    public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор
//    public Person(string n) { name = n; age = 18; }         // 2 конструктор
//    public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

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





























// Задание



phone first = new phone();
first.number = 1;
first.model = "xaomi";
first.weight = 2;
first.name = "tom";

phone second = new phone();
second.number = 2;
second.model = "iphone";
second.weight = 3;
second.name = "bob";

phone third = new phone();
third.number = 3;
third.model = "samsung";
third.weight = 4;
third.name = "luise";

phone fourth = new phone(4, "meizu", 2);

phone fifth = new phone(5, "oppo", 2);

(int number, string model) = fifth;


phone sixth = new phone();


first.Print();
second.Print();
third.Print();
fourth.Print();
fifth.Print();
sixth.Print();


first.receiveCall();
second.receiveCall();
third.receiveCall();

first.getNumber();
second.getNumber();
third.getNumber();


