using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanC.Programacion.Eval1.Juego.Logica
{
    public class ModeloJuego
    {
        
        static int[,] matriu = { { 2, 0, 0, 0 }, { 2, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        static Random alea = new Random();
        public static void Anadir(int cont) 
        {
            
            
            while (cont > 0)
            {
                int pos1 = alea.Next(0, 3);
                int pos2 = alea.Next(0, 3);
                if (matriu[pos1, pos2] == 0)
                {
                    matriu[pos1, pos2] = 2;
                    cont--;
                }
            }
        }
        public static void Mostrar()
        {
            int puntuacion = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i=0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    switch (matriu[i, j])
                    {
                        case 0: Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("   {0}", matriu[i, j]);
                            break;
                        case 2: Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write("   {0}", matriu[i, j]);
                            break;
                        case 4: Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write("   {0}", matriu[i, j]);
                            break;
                        case 8: Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write("   {0}", matriu[i, j]);
                            break;
                        case 16: Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write("  {0}", matriu[i, j]);
                            break;
                        case 32: Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("  {0}", matriu[i, j]);
                            break;
                        case 64: Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Write("  {0}", matriu[i, j]);
                            break;
                        default: Console.Write("{0}", matriu[i, j]);
                            break;
                    }
                    puntuacion += matriu[i, j];
                 
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Puntuacion: {0}",puntuacion);
            
        }
        public static void Direccion(ConsoleKeyInfo dirc)
        {
            switch (dirc.Key)
	        {
                case ConsoleKey.W: Arriba();
                    break;
                case ConsoleKey.S: Abajo();
                    break;
                case ConsoleKey.A: Izquierda();
                    break;
                case ConsoleKey.D: Derecha();
                    break;
                default: Console.WriteLine("No es una direccion adecuada.");
                    break;
            }
            
        }
        public static void Arriba()
        {
            for (int j = 0; j < 4; j++)
            {

                OrganizarArriba(j);
                for (int i = 3; i >= 0; i--)
                {
                    if (matriu[i, j] != 0)
                    {
                        if (i-1 >= 0)
                        {
                            if (matriu[i, j] == matriu[i - 1, j])
                            {
                                matriu[i - 1, j] = matriu[i, j] + matriu[i - 1, j];
                                matriu[i, j] = 0;
                                i--;
                            }
                        }
                    }
                }
                OrganizarArriba(j);     
            }
        }
        public static void OrganizarArriba(int j)
        {
                for (int x = 1; x < 4; x++)
                {
                    for (int cont = x; cont > 0; cont--)
                    {
                        if (matriu[cont - 1, j] == 0)
                        {
                            matriu[cont - 1, j] = matriu[cont, j];
                            matriu[cont, j] = 0;
                        }
                    }
                }
            
        }
        public static void Abajo()
        {
            for (int j = 0; j < 4; j++)
            {

                OrganizarAbajo(j);
                for (int i = 0; i < 4; i++)
                {
                    if (matriu[i, j] != 0)
                    {
                        if (i + 1 <= 3)
                        {
                            if (matriu[i, j] == matriu[i + 1, j])
                            {
                                matriu[i + 1, j] = matriu[i, j] + matriu[i + 1, j];
                                matriu[i, j] = 0;
                                i++;
                            }
                        }
                    }
                }
                OrganizarAbajo(j);
            }
        }

        public static void OrganizarAbajo(int j)
        {
            for (int x = 2; x >= 0; x--)
            {
                for (int cont = x; cont < 3; cont++)
                {
                    if (matriu[cont + 1, j] == 0)
                    {
                        matriu[cont + 1, j] = matriu[cont, j];
                        matriu[cont, j] = 0;
                    }
                }
            }

        }
        public static void Izquierda()
        {
            for (int i = 0; i < 4; i++)
            {

                OrganizarIzquierda(i);
                for (int j = 3; j >= 0; j--)
                {
                    if (matriu[i, j] != 0)
                    {
                        if (j - 1 >= 0)
                        {
                            if (matriu[i, j] == matriu[i, j - 1])
                            {
                                matriu[i, j - 1] = matriu[i, j] + matriu[i, j - 1];
                                matriu[i, j] = 0;
                                j--;
                            }
                        }
                    }
                }
                OrganizarIzquierda(i);
            }
        }
        public static void OrganizarIzquierda(int i)
        {
            for (int x = 1; x < 4; x++)
            {
                for (int cont = x; cont > 0; cont--)
                {
                    if (matriu[i, cont - 1] == 0)
                    {
                        matriu[i, cont - 1] = matriu[i, cont];
                        matriu[i, cont] = 0;
                    }
                }
            }

        }
        public static void Derecha()
        {
            for (int i = 0; i < 4; i++)
            {

                OrganizarDerecha(i);
                for (int j = 0; j < 4; j++)
                {
                    if (matriu[i, j] != 0)
                    {
                        if (j + 1 <= 3)
                        {
                            if (matriu[i, j] == matriu[i, j + 1])
                            {
                                matriu[i, j + 1] = matriu[i, j] + matriu[i, j + 1];
                                matriu[i, j] = 0;
                                j++;
                            }
                        }
                    }
                }
                OrganizarDerecha(i);
            }
        }
        public static void OrganizarDerecha(int i)
        {
            for (int x = 2; x >= 0; x--)
            {
                for (int cont = x; cont < 3; cont++)
                {
                    if (matriu[i, cont + 1] == 0)
                    {
                        matriu[i, cont + 1] = matriu[i, cont];
                        matriu[i, cont] = 0;
                    }
                }
            }

        }
    }
}
