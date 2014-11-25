using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        int Salud = 100;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public readonly DateTime Creacion = DateTime.Now;

        public DateTime FechaNacimiento;

        public Persona(string nombre, string apellido): this(nombre)
        {
            this.Creacion = DateTime.Now;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }



        string nombre;
        string apellido;

        public string Nombre
        {
            get { return this.nombre; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("El nombre no es valido", "Nombre");

                this.nombre = value; 
            }

        }
        public void SetNombre(string queNombre)
        {
            this.nombre = queNombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string Presentarse()
        {
            return "Hola, me llamo " + this.NombreCompleto();
        }
        public string NombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }
        public string PresentarA(Persona otra)
        {
            return "Te presento a " + otra.NombreCompleto();
        }
    }
   
    
}
