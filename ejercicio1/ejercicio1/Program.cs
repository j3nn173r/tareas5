using System;
using System.Threading;

namespace ejercicio1
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int Length)
        {
            string result = parametro.Substring(startindex, Length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOM;
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;
            int CF = 0;
            Console.Write("Ingrese su nombre: ");
            NOM = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(NOM);
            CI = NOM.Length;
            CF = 70;
            NOM = NOM.ToUpper();
            for (P = NOM.Length; P >= 1; P--)
            {
                CAR = Mid(NOM, P - 1, 1);
                for (K = CI; K <= CF; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + CAR);
                    Thread.Sleep(50);
                }
                CF = CF - 1;
                CI = CI - 1;
            }
        }
    }
}






