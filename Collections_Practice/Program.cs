using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
                //Array with 0-9
            int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
                //Array with four names
            string[] nameArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
                //Boolean array alternating true and false
            bool[] truthArray = new bool[10];
            for(int i=0; i<10; i+=2){
                truthArray[i] = true;
            }

            //Multiplication table
            int[,] mult = new int[10,10];
            for(int x=0; x<10; x++){
                for(int y=0; y<10; y++){
                    mult[x,y] = (x+1)*(y+1);
                }
            }
            for(int x=0; x<10; x++){
                string display = "[";
                for(int y=0; y<10; y++){
                    if(y<9){
                        display += mult[x,y] + ",";
                    }
                    else{
                        display += mult[x,y];
                    }
                    //To add space after single digits to make grid symmetrical
                    if(mult[x,y] < 10){
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine(display);
            }

            //Ice Cream List
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Milk and Cookies");
            flavors.Add("Cookie Dough");
            flavors.Add("Neopolitan");
            flavors.Add("Rainbow Sherbet");
                //Output list length
            Console.WriteLine(flavors.Count);
                //Print third value, then remove it
            Console.WriteLine("The third flavor in the list is "+flavors[2]);
            flavors.RemoveAt(2);
                //Output the new length
            Console.WriteLine("The new length of the list is "+flavors.Count);

            //Dictionary of Name to Ice Cream Flavor
            Dictionary<string,string> ourFaves = new Dictionary<string,string>();
            Random rand = new Random();
            foreach(string name in nameArray){
                ourFaves[name] = flavors[rand.Next(flavors.Count)];
            }
            Console.WriteLine("Our favorite ice cream flavors:");
            foreach(KeyValuePair<string,string> person in ourFaves){
                Console.WriteLine(person.Key+"-"+person.Value);
            }
        }
    }
}