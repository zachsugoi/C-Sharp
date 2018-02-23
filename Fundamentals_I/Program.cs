using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop that prints all values 1-255
            for(int i=1; i<=255; i++)
            {
                Console.WriteLine(i);
            }

            //Loop that prints all values 1-100 that are divisible by 3 or 5, but not both
            for(int i=1; i<=100; i++)
            {
                if(!(i % 15 == 0))
                {
                    if(i % 3 == 0 || i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //Between 1-100: "Fizz" for 3's, "Buzz" for 5's, "FizzBuzz" for multiples of both
            for(int i=1; i<=100; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            //Same as above, but without using modulus
            int three = 3;
            int five = 5;
            for(int i=1; i<=100; i++)
            {
                three--;
                five--;
                if(three == 0 && five == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;
                }
                else if(three == 0)
                {
                    Console.WriteLine("Fizz");
                    three = 3;
                }
                else if (five == 0)
                {
                    Console.WriteLine("Buzz");
                    five = 5;
                }
            }

            //Generate 10 random values 1-100 and output "FizzBuzz" as above
            Random rand = new Random();
            for(int i=1; i<=10; i++)
            {
                int val = rand.Next(1,100);
                string output = "For attempt "+i+" the value is "+val+" and the word is ";
                if(val % 3 == 0 && val % 5 == 0)
                {
                    output += "FizzBuzz";
                }
                else if(val % 3 == 0)
                {
                    output += "Fizz";
                }
                else if(val % 5 == 0)
                {
                    output += "Buzz";
                }
                else
                {
                    output += "nothing special";
                }
                Console.WriteLine(output);

            }
        }
    }
}
