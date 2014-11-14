using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanC.Programacion.Eval1.Juego.Logica;

namespace JuanC.Programacion.Eval1.Juego.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = ModeloJuego.SecretoDeLaVida();
            Console.WriteLine("El secreto de la vida es:" + secreto);
            Console.ReadKey();
        }
    }
}
