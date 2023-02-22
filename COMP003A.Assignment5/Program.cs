/*
 * Author: Ruben Villagrana
 * Course: COMP-003A
 * Purpose: Assignment 4 Code
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace PrintSeparator

{
    class Program
    {
        static void PrintSeparator()

        {


            static void Main(string[] args)
            {
                
                Console.WriteLine("**************************************************************");
                Console.WriteLine("Triangle Section");
                Console.WriteLine("*************************************************************");
                Console.WriteLine("Enter a Single Character:");
                Console.WriteLine("Enter a Positive Whole Number");


                static void PrintSeparater(int N)
                {

                    char[] arr = new char[N];
                    int i, j;

                    // Loop to print the upper half
                    // diamond pattern
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < i + 1; j++)
                            Console.Write("*");
                        Console.Write("\n");
                    }

                    // Loop to print the lower half
                    // diamond pattern
                    for (i = 1; i < N; i++)
                    {
                        for (j = i; j < N; j++)
                            Console.Write("*");
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}


    


    
