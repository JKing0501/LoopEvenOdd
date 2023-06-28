/* This is my Conditional and Iterative Statement assignment 
 * By Jason Wang
 * Date: 6/27/2023
 * Professor: Weimar Ardila Rueda
 * Course: Managing Information Resources
 */
using System;
using System.Linq.Expressions;

namespace Conditional_and_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int num = 0;
                while (true)
                {
                    Console.WriteLine("Enter an integer value between 1 and 100.");
                    num = int.Parse(Console.ReadLine());
                    if (num >=1 && num<=100)
                    {
                        break;
                    }
                }

                Console.Write("Please enter an series type: even or odd? ");
                string series=Console.ReadLine();
                //The even number loops
                switch (series)
                {
                    case "even":
                        Console.WriteLine("You have selected the even series. The numbers between 0 and " + num, "are: ");
                        for (int i = 0; i < num; i++)
                        {
                            int even = i++;
                            Console.WriteLine(even);
                        }
                        break;
                        
                    case "odd":
                        Console.WriteLine("You have selected the odd series. The numbers between 0 and " + num, "are: ");
                        for (int i = 0; i <= num; i++)
                        {
                            if (i % 2 == 1)
                            {
                                int odd = i++;
                                Console.WriteLine(odd);
                            }
                            
                        }
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Please enter an valid integer!");
            }
        }
    }
}