using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_one_out
{
    class Program
    {
        static void Main(string[] args)
        {

            ValidationStation();
            //calculate sum of the odd numbers between 1 and the user input
            //calculate the average of the odd numbers 
            //create a method to hold the calculations

        }

        static void ValidationStation()
        {

            while (true)
            {
                //validate data            
                //prompt user to enter a number
                try
                {
                    Console.WriteLine("Enter a whole number less than 50");
                    double rangeNum = double.Parse(Console.ReadLine());


                    if (rangeNum <= 50)
                    {
                        
                        Console.WriteLine($"The sum of the odd numbs are {SumOfOdd(rangeNum)}");
                        Console.WriteLine($"The average of the odd numbs are {AverageOfOdd(rangeNum)}"); 
                    }

                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, try again");

                }

            }
            
        }

        static double SumOfOdd(double userInput)
        {
            double sum = 0;
            for (int i = 0; i < userInput; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                    sum = i++;
                    
                    
                }

            }
            return sum;
           
        }

        static double AverageOfOdd(double userInput)
        {
            double ave = 0;
            for (int i = 0; i < userInput; i++)
            {

                //find the average sucks. Loop back after completing everything else to figure out this average out....\\update, i didn't have enough time to fix it 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    ave = (i++) /i;


                }
           
            }
            return ave;


        }
    }
}
