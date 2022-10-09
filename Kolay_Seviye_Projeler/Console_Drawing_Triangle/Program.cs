using System;

namespace Ucgen_Cizim
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetTheLength();
            
            DrawTriangle(n);
        }

        static int GetTheLength()
        {
            Console.Write("Bir sayı giriniz: ");
            return int.Parse(Console.ReadLine());
        }

        static void DrawTriangle(int n)
        {
            for(int i=1; i<= n; i++)
            {
                for (int j = n-i; j > 0; j--)
                {
                   Console.Write(" ");
                }

                for (int k = 1; k <= 2*(i-1)+1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}