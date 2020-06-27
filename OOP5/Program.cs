using System;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person ("Gates", "Bill" );
            Employee emp = new Employee ("Smith", "Tom", "Microsoft");
            p.Display();
            emp.Display();
            Console.ReadKey();
        }
    }
    class Employee : Person
    {
        private string _company;
        public Employee(string name, string surname, string comp) 
            : base(name, surname)
        {
            Company = comp;
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

    }
   class Person
    {
        private string _firstName;
        private string _lastName;
        public Person()
        {
            _firstName = "Tom";
        }
        public Person (string name, string surname)
        {
            _firstName = name; _lastName = surname;
        }
        
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
