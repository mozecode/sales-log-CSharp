using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyPA6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSales Logging System");
            Console.WriteLine();//blank

            double[] sales = new double[10];


            double sum = 0;
            int counter = 0;

            for (int i = 0; i < sales.Length; i++)
            {

                Console.Write("Enter your sales value {0}: $", i + 1);

                while (double.TryParse(Console.ReadLine(), out sales[i]) == false || sales[i] < 0)
                {
                    Console.WriteLine("Try again: ");
                }

                Console.WriteLine();//blank
                counter++;

                if (sales[i] == 0)
                {
                    Array.Sort(sales); // high to low
                    Array.Reverse(sales);
                    Console.WriteLine("The 3 highest sales were:");
                    Console.WriteLine("  >> {0:C}", sales[0]);
                    Console.WriteLine("  >> {0:C}", sales[1]);
                    Console.WriteLine("  >> {0:C}", sales[2]);

                    foreach (double item in sales)
                    {
                        sum = sum + item;
                    }

                    Console.WriteLine("The average of all sales was {0:C}.", sum / (counter-1));
                    break;
                }


            }//end of for loop

            Console.ReadKey();

        }//end of main

    }
}
