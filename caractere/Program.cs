using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
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
            Console.Write("SU NOMBRE ES: ");
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
                    // REALIZAMOS UNA PAUSA
                    System.Threading.Thread.Sleep(50);
                }
                CF = CF - 1;
                CI = CI - 1;
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
    }
}
