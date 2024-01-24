using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] ranum = new int[10];
            int[] numArry = { 50, 12, 42, 77, 32, 10, 12, 53, 5, 3 };

            //SelctionSort(numArry);
            //BubbleSort(numArry);
            InsertionSort(numArry);


            //RandArry(random, ranum);


            //SelctionSorting(ranum);


            //indexe(ranum);


        }

        private static void InsertionSort(int[] numArry)
        {
            for (int i = 0; i < numArry.Length -1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numArry[j - 1] > numArry[j])
                    {
                        int temp = numArry[j - 1];
                        numArry[j - 1] = numArry[j];
                        numArry[j] = temp;
                    }
                }
            }

            foreach (var item in numArry)
            {
                Console.Write(item + " ");
            }
        }

        private static void RandArry(Random random, int[] ranum)
        {
            for (int i = 0; i < ranum.Length; i++)
            {
                int s = random.Next(1, 100);
                ranum[i] = s;
            }

            Console.WriteLine("Unsorted");

            foreach (var item in ranum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void BubbleSort(int[] numArry)
        {
            int manimum = 0;
            for (int i = 0; i < numArry.Length; i++)
            {
                for (int B = i + 1; B < numArry.Length; B++)
                {

                    if (numArry[i] > numArry[B])
                    {
                        manimum = numArry[B];
                        numArry[B] = numArry[i];
                        numArry[i] = manimum;
                    }
                }
                
            }

            Console.WriteLine("Bubble Sorting: ");
            foreach (var item in numArry)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void indexe(int[] ranum)
        {
            int userInput;

            do
            {
                Console.Write("Enter Number To Finde it Inise arry (-1) To Exit: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == -1)
                {
                    break;
                }

                int FoundIndex = BinarySearch(ranum, userInput);

                if (FoundIndex >= 0)
                {
                    Console.WriteLine("{0} is in index {1} ", userInput, FoundIndex);

                }
                else
                {
                    Console.WriteLine("{0} is Not Found", userInput);
                }

            } while (userInput >= 0);
        }

        private static int BinarySearch(int[] ranum, int userInput)
        {
            int left = 0;
            int right = ranum.Length -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (ranum[mid] == userInput)
                {
                    return mid;
                }
                else if (ranum[mid] < userInput)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

    

        private static void SelctionSort(int[] numArry)
        {
            for (int i = 0; i < numArry.Length - 1; i++)
            {
                int manimum = i;

                for (int j = i + 1; j < numArry.Length; j++)
                {

                    if (numArry[manimum] > numArry[j])
                    {
                        manimum = j;
                    }
                }
                int swap = numArry[i];
                numArry[i] = numArry[manimum];
                numArry[manimum] = swap;

            }

            Console.WriteLine("Sorted");

            foreach (var item in numArry)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

