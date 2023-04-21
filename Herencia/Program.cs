using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Juan", 40, "cardiologo");
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());

            Dev dev1 = new Dev("Héctor", 10, "C#");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());
        }

        // Clase base (padre): la clase de la que se hereda. en este caso People
        class People
        {
            private string _name;
            private int _age;
            public People(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string GetInfo()
            {
                return _name + " " + _age;
            }
        }

        // Clase derivada (hijo): la clase que hereda de otra clase. En este clase Doctor
        class Doctor : People
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;
            }

            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        // La clase Dev hereda de People
        class Dev : People
        {
            private string _language;
            
            public Dev(string name, int age, string language) : base(name, age)
            {
                _language = language;
            }

            public string GetData()
            {
                return GetInfo() + " " + _language;
            }

        }
    }
}
