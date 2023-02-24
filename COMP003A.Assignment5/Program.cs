/* Author: Ruben Villagrana
 * Course: COMP003A
 * Purpose: Methods and XML comments Assignment5
 */
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle");
            IsoscelesTriangleBuilder('/' , 10);

            //Console.WriteLIne(AgeCalculator
            Console.WriteLine("******************************************************");
            Console.WriteLine("Triangle Section");
            Console.WriteLine("*******************************************************");
        }
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        static void PrintSeparator(string title)
        {
            PrintSeparator();
            Console.WriteLine($"\t{title} Section.");
            PrintSeparator();

        }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string output = "";
            //increasing 
            for (int i = 0; i < size; i++)
            {
                output += inputCharacter;
                Console.WriteLine(output);
                //Console.WriteLine("".PadRight(i, inputCharacter));
            }

            //decreasing
            for (int i = size - 1; i > 0; i--)
            {
                output = output.Substring(0, i);
                Console.WriteLine(output);


               
                //Age calculator takes one parameter
                static int AgeCalculator(int year)
                {   
                    //Return current value of current year, minus a year 
                    return DateTime.Now.Year - year;

                }
                    //Character info with two parameters
                static void CharacterInfo(string name, int birthYear)
                {   
                    //Method is called age calculator with birthyear as parameter
                    int age = AgeCalculator(birthYear);

                    //Output name and calculated age to console
                    Console.WriteLine($"{name} turns {age} this year");

                    
                    CharacterInfo("Spawn", DateTime.Now.Year - 2023);
                    Console.WriteLine($"{name} turns {age} this year");
                    
                    
                    CharacterInfo("Ted Mosby", DateTime.Now.Year - 2023);
                    Console.WriteLine($"{name} turns {age} this year");
                    
                    CharacterInfo("Ultimate Warrior", DateTime.Now.Year - 2023);
                    Console.WriteLine($"{name} turns {age} this year");
                    
                    CharacterInfo("Marvin the Martian", DateTime.Now.Year - 2023);
                    Console.WriteLine($"{name} turns {age} this year");
                    
                    CharacterInfo("Himura Kenshin", DateTime.Now.Year - 2023);
                    Console.WriteLine($"{name} turns {age} this year");
                    

                }
            }
        }
    }
} 
                
               



   
            
            
            
            


      
    

