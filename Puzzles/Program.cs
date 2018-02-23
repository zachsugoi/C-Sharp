using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles
{
    class Program
    {
        //Function that creates array w/ 10 random ints between 5-25, prints
        //min and man values of array, and prints sum of all values
        public static int[] RandomArray(){
            Random rand = new Random();
            int[] randArr = new int[10];
            int sum = 0;
            for(int i=0; i<10; i++){
                int num = rand.Next(5,26);
                randArr[i] = num;
                sum += num;
            }
            Console.WriteLine("The max value of the random array is {0}", randArr.Max());
            Console.WriteLine("The min value of the random array is {0}", randArr.Min());
            Console.WriteLine("The sum of the values of the random array is {0}", sum);
            return randArr;
        }

        //Create function that resembles a coin toss
        public static string TossCoin(){
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            string result = "Tails";
            if(rand.Next(0,2) == 0){
                result = "Heads";
            }
            Console.WriteLine(result);
            return result;
        }

        //Create function that returns ratio of heads to total tosses after calling
        //a specified number of coin tosses
        public static double TossMultipleCoins(int num){
            int heads = 0;
            for(int i=0; i<num; i++){
                string toss = TossCoin();
                if(toss == "Heads"){
                    heads++;
                }
            }
            double ratio = (double)heads/(double)num;
            Console.WriteLine("The ratio of heads to total tosses is {0}", ratio);
            return ratio;
        }

        //Create function that shuffles an array of names and prints them in the 
        //new order. Return an array that only includes names longer than 5 characters
        public static string[] Names(){
            string[] names = new string[5] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            Random rand = new Random();
            for(var idx=0; idx<names.Length-1; idx++){
                int randIdx = rand.Next(idx+1,names.Length);
                string temp = names[idx];
                names[idx] = names[randIdx];
                names[randIdx] = temp;
            }
                //print the names in the new order
            string newOrder = "[";
            foreach(string name in names){
                newOrder += name + ",";
            }
            Console.WriteLine(newOrder);
                //return array w/ only names w/ >5 characters
            List<string> nameList = new List<string>();
            foreach(var name in names){
                if(name.Length > 5){
                    nameList.Add(name);
                }
            }
            return nameList.ToArray();
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(7);
            string[] names = Names();
            string finalNameList = "[";
            foreach(string name in names){
                finalNameList += name + ",";
            }
            finalNameList += "]";
            Console.WriteLine(finalNameList);
        }
    }
}
