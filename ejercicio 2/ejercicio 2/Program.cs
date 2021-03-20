using System;
using System.Threading;

namespace ejercicio_2
{
    class Program
    {
        public static void Dibuja(int cantidad)
        {
            int Fila = 17;
            int colum = 30;
            int f_interna = 2;
            int posicion = 2;
            int F, C, A;

            for (A = 1; A <= cantidad; A++)
            {
                for (F = posicion; F <= colum; F++)
                {
                    Console.SetCursorPosition(F, Fila); Console.Write("0");
                    Console.SetCursorPosition(F, f_interna); Console.Write("0");
                }
                for (C = f_interna; C <= Fila; C++)
                {
                    Console.SetCursorPosition(posicion, C); Console.Write("1");
                    Console.SetCursorPosition(colum, C); Console.Write("1");
                }
                f_interna = f_interna + 1;
                Fila = Fila - 1;
                posicion = posicion + 1;
                colum = colum - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam < 9; tam++)
            {
                Dibuja(tam);
                Thread.Sleep(1000);
            }

        }
    }
}



