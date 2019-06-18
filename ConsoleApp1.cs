using System;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int freq = 1000;
            {

            }
            while (n < 10000)
            {
                Console.Beep(freq, 10000);
                n++;
                freq += 100;
            }
       
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            while (1 == 1)
            {
                Console.ReadKey();
            }
     
            
            
        }
    }
}
