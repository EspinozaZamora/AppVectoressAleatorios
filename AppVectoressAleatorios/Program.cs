using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectoressAleatorios
{
    class Program
    {
        const int MAX = 100;

        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            leerVectorr(x);
            Console.WriteLine("\n Elementosdel Vector  ");
            imprimirVector(x);
            Console.ReadKey();

        }
        public static void leerVectorr (int [] x)
        {
            for(int i=0; i<MAX; i++)
            {
                var randomNumber = new Random().Next(1, 5000);
                x[i] = randomNumber;


            }
        }
        public static void imprimirVector(int [] x)
        {
            for (int i = 0; i < MAX; i++)
                Console.WriteLine(x[i]);
        }
    }
}
