using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        //Prints values 1 to 255
        public static void Print1to255(){
            for(int i=1; i<=255; i++){
                Console.WriteLine(i);
            }
        }

        //Prints all odd values between 1-255
        public static void PrintOdds(){
            for(int i=1; i<=255; i++){
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }
        }

        //Prints sum of all numbers between 0-255, as counting up to 255
        public static void PrintSum(){
            int sum = 0;
            for(int i=0; i<=255; i++){
                sum += i;
                Console.WriteLine($"New Number: {i} Sum: {sum}");
            }
        }

        //Iterate through a passed array of integers
        public static void ArrayIterate(int[] arr){
            string output = "[";
            for(int i=0; i<arr.Length; i++){
                output += arr[i] + ",";
            }
            output += "]";
            Console.WriteLine(output);
        }

        //Find max value in passed array
        public static void MaxInArray(int[] arr){
            int max = arr[0];
            foreach(int num in arr){
                if(num > max){
                    max = num;
                }
            }
            Console.WriteLine("The max value is {0}", max);
        }

        //Get average value of an array
        public static void AvgOfArray(int[] arr){
            int sum = GetSum(arr);
            Console.WriteLine("This average is "+(double)sum/(double)arr.Length);
        }
        public static int GetSum(int[] arr){
            int sum = 0;
            foreach(int num in arr){
                sum += num;
            }
            return sum;
        }

        //Create array of odd numbers between 1-255
        public static int[] CreateOddArray(){
            List<int> oddList = new List<int>();
            for(int i=1; i<=255; i++){
                if(i % 2 == 1){
                    oddList.Add(i);
                }
            }
            return oddList.ToArray();
        }

        //Count all values in array that are greater than y
        public static void GreaterThanY(int[] arr, int y){
            int count = 0;
            foreach(int num in arr){
                if(num > y){
                    count++;
                }
            }
            Console.WriteLine($"There are {count} values greater than {y}");
        }

        //Square all values in a given array
        public static void SquareArrayValues(int[] arr){
            for(int i=0; i<arr.Length; i++){
                arr[i] *= arr[i];
            }
        }

        //Turn negative numbers in array into 0
        public static void ReplaceNegatives(int[] arr){
            for(int i=0; i<arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
        }

        //Retrieve the max, min, and avg values from a given array
        public static void MaxMinAvg(int[] arr){
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            foreach(int val in arr){
                sum += val;
                if(val > max){
                    max = val;
                }
                if(val < min){
                    min = val;
                }
            }
            Console.WriteLine("The max of the array is {0}, the min is {1}, and the average is {2}", max, min, (double)sum/(double)arr.Length);
        }

        //Shift values in array forward by 1 place and make the last space be 0
        public static void ShiftLeft(int[] arr){
            for(int i=0; i<arr.Length-1; i++){
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = 0;
        }

        //Replace negatives in array with "dojo"
        public static void ReplaceNumberWithString(object[] arr){
            for(int i=0; i<arr.Length; i++){
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
            }
        }

        static void Main(string[] args)
        {
            Print1to255();
            PrintOdds();
            PrintSum();
            int[] myArr = new int[6] {1,3,5,7,9,13};
            ArrayIterate(myArr);
            MaxInArray(myArr);
            AvgOfArray(myArr);
            MaxInArray(myArr);
            AvgOfArray(myArr);
            CreateOddArray();
            GreaterThanY(myArr,4);
            SquareArrayValues(myArr);
            ReplaceNegatives(myArr);
            ShiftLeft(myArr);
            MaxMinAvg(myArr);
            ShiftLeft(myArr);
            object[] boxedArray = new object[] {-1,3,2,-16};
            ReplaceNumberWithString(boxedArray);

        }
    }
}
