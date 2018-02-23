using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create empty list of type object
            List<object> myList = new List<object>();

            //Add some integers, a boolean, and a string
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            //Loop through the list and print all values
            int sum = 0;
            foreach(var obj in myList){
                Console.WriteLine(obj);
                if(obj is int){
                    sum += (int)obj;
                }
            }
            Console.WriteLine("The sum of all integers in the list is {0}.", sum);
        }
    }
}
