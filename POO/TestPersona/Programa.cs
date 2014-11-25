using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace TestPersona
{
    static class Programa
    {
        static void Main()
        {
            Persona p = new Persona("Jaime");
            Console.WriteLine(p.Creacion);
            p.FechaNacimiento = new DateTime(1989, 4, 12);
            
            //p.Creacion = DateTime.Now;
            //Persona p = new Persona("Paco");
            //p.SetNombre("Rodolfo");
            //string n = p.GetNombre();

            //p.Nombre = "Pablo";
            //p.Apellido = "Iglesias";
            //Console.WriteLine(p.Nombre);

            Console.ReadKey();
        }
        //static void Main()
        //{
        //    //Pruebas();
        //    TestPresentarse();
        //    Console.ReadKey();
        //}

        //private static void Pruebas()
        //{
        //    Persona p;
        //    p = new Persona();

        //    Persona p2;
        //    p2 = p;

        //    p.Nombre = "Pepito";
        //    p2.Apellido = "Lopez";
        //    Console.WriteLine(p2.Nombre);

        //    Console.ReadKey();

        //    p2 = null;
        //    if (p2 != null)
        //        Console.WriteLine(p2.Nombre);

        //    Console.ReadKey();
        //}

        //static void TestPresentarse()
        //{
        //    Persona p1 = new Persona();
        //    p1.Nombre = "Roberto";
        //    p1.Apellido = "Perez";

        //    Persona p2 = new Persona();
        //    p2.Nombre = "Rodolfo";
        //    p2.Apellido = "Gomez";

        //    Console.WriteLine(p1.PresentarA(p2));

        //    //string nc = p1.NombreCompleto();

        //    Console.WriteLine(p1.Presentarse());
        //    Console.WriteLine(p2.Presentarse());
        //}
    }
}
