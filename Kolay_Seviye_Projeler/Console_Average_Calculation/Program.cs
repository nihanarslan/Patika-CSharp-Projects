using System;

namespace Console_Average_Calculation 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            bool state = int.TryParse(Console.ReadLine(), out int i);
            
            int toplam = CalculateAverage(i);

            Console.WriteLine("\nOrtalama = {0}",(float)toplam/i);

        }

        static int CalculateAverage(int i)
        {
            int toplam=0, a=0, b=0, temp = 0;
            while(i>0)
            {
                Console.Write(a +" ");
                if(a == 0)
                    b++;
                toplam += a;
                temp = b;
                b = a+b;
                a = temp;
                i--;
            }

            return toplam;
        }
    }
}