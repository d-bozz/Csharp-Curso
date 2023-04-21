using BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkSystem
{
    /** 
     * Este proyecto utiliza el proyecto anterior con Entity framework
     * Para ello se configura en las dependencies > Project Reference
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            // Genero un Builder con la conexion a la base para eliminar la creacion automatica del EF con el warning
            DbContextOptionsBuilder<CsharpDBContext> optionsBuilder =
                new DbContextOptionsBuilder<CsharpDBContext>();
            optionsBuilder.UseSqlServer("Server=DITOXLAP02\\SQLEXPRESS03;Database=CsharpDB;Trusted_Connection=True;");

            bool again = true;
            int op = 0;

            // Gago un menu de opciones
            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opción:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        again = false;
                        break;

                }

            } while (again);
        }

        // Recibe por parametro del DBContext para hacer uso de las operaciones
        // Usando LINQ modifico la informacion de la base
        public static void Show(DbContextOptionsBuilder<CsharpDBContext> optionBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas en la base de datos");

            // Con el using le indico que quiero utilizar el optionBuilder y destruirlo con el Dispose al finalizar
            // Para liberar los recursos de conexion a la base de datos
            using (var context = new CsharpDBContext(optionBuilder.Options))
            {

                List<Beer> beers = (from b in context.Beers
                                     where b.BrandId == 2
                                     orderby b.Name
                                     select b).Include(b=>b.Brand).ToList();
            }
        }

        public static void Add(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca:");
            int brandId = int.Parse(Console.ReadLine());
            using (var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = brandId
                };
                context.Add(beer);
                context.SaveChanges();
            }
        } 

        public static void Edit(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Editar cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar");
            int id = int.Parse(Console.ReadLine());
            using (var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if(beer != null)
                {
                    Console.WriteLine("Escribe el nombre:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Esribe el id de la marca");
                    int brandId = int.Parse(Console.ReadLine());
                    beer.Name = name;
                    beer.BrandId = brandId;
                    context.Entry(beer).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Cerveza no existe");
                }
            }
        }

        public static void Delete(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Show(optionsBuilder);
            Console.WriteLine("Eliminar cerveza");
            Console.WriteLine("Escribe el id de la cerveza a eliminar:");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if (beer != null)
                {
                    context.Beers.Remove(beer);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Cerveza no existe");
                }
            }
        }

        public static void ShowMenu()
        {

            Console.WriteLine("\n----------Menu----------");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");
        }
    }
}
