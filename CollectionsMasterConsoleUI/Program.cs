using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] arrayNumbers = new int[50];
            Populater(arrayNumbers);
            Console.WriteLine(arrayNumbers[0]);
            Console.WriteLine(arrayNumbers[49]);
            int[] arrayNumbers_b = (int[])arrayNumbers.Clone();
          
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            

            //Print the first number of the array

            //Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(arrayNumbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(arrayNumbers);
            NumberPrinter(arrayNumbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(arrayNumbers_b);
            
            

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            /*for (int i = 0; i < 50; i++)
                { 
                if (arrayNumbers[i]%3==0)
                    {
                    arrayNumbers[i] = 0;
                    }
                }
            NumberPrinter(arrayNumbers);*/
            ThreeKiller(arrayNumbers);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayNumbers_b);
            NumberPrinter(arrayNumbers_b);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> numberList = new List<int>();
            Console.WriteLine(" the Capacity of the list is " + numberList.Capacity);

            //Print the capacity of the list to the console


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this

            Populater(numberList);
            NumberPrinter(numberList);



            //Print the new capacity
            Console.WriteLine(" the Capacity of the list is now " + numberList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(numberList);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);

            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numberList.ToArray();


            //Clear the list
            numberList.Clear();
            

            #endregion
        }

        
      
        
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < 50; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (var element in numberList.ToList())
            {
                if (element % 2 != 0)
                    numberList.Remove(element);
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList)
        {
            
            
            bool repeatUntill = false;
            
            while (repeatUntill == false) 
            {
                var searchNumber= int.Parse(Console.ReadLine());
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine("The list contains your number");
                    repeatUntill = true;

                }

                else
                {
                    Console.WriteLine("The list does not contain that number, please try again");
                   
                }
            }
            

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                var num = random.Next(0,50);
                numberList.Add(num);
                
            }
           
        }


        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();

                numbers[i] = random.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 49; i >= 0; i--)
                Console.WriteLine(array[i]);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
