using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
           // 
            
            int counter = 1,i;

            do
            {
                for (i = 0; i < counter; i++)
                {
                    Console.Write(counter);                    
                }
                Console.WriteLine();  //for new line
                counter++;
            }
            while
            (counter < 6);

            Console.WriteLine("Hello World!");

            int count = 1;
            do
            {
                for (i=5; i>=count;i--)  // i denotes number of rows
                {
                    for (int j = 0; j < i; j++) // it denotes no of coloums
                    {
                        Console.Write(" ");
                    }

                    for (int k = 5; k >= i; k--)
                    {
                        Console.Write("1");
                    }
                    Console.WriteLine();
                }
                count++;
            }
            while (count<8);

            

            for (i = 1; i <= 6; i++)
            {
                for (int j = 6 - i; j >= 1; j--)

                    Console.Write(" ");
            }
            for (int k = 1; k <= (i * 2) - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
           

            Console.ReadKey();
        }
    }
}
