using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Generic significa que no es específico de un tipo de datos en particular.
             * 
             * Una clase genérica aumenta la reutilización. Cuantos más parámetros de tipo, más reutilizable se vuelve. 
             * Sin embargo, demasiada generalización hace que el código sea difícil de entender y mantener.
             **/

            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!";

            // Creo una lista de int usando la clase Generic MyList
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(10);

            // Creo una lista de strings usando la clase Generic MyList
            MyList<string> strings = new MyList<string>(10);
            strings.Add("Héctor");

            // Creo una lista de objetos usando la clase Generic MyList
            MyList<People> people = new MyList<People>(5);
            people.Add(new People() { Name = "Héctor", Country = "México" });
        }

    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, País {Country}";
        }

    }

    public class DataStore<T>
    { 
        public T Data { get; set; }
    }

// Tengo la clase Generic MyList donde indico un arreglo pero no especifico el tipo
public class MyList<T>
{
    private T[] _elements;
    private int _index = 0;

    public MyList(int n)
    {
        _elements = new T[n];
    }

    public void Add(T e)
    {
        if(_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }
}
}
