using System;

namespace Lesson_4___2022_07_04
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }

        static int[] RandomArray(int a)
        {
            int size = a;

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }


        //1. Find the minimum element of an array
        static int GetMinElementOfArray(int [] array)
        {      
            return array[GetMinIndexOfArray(array)];
        }


        //2. Find the maximum element of an array
        static int GetMaxElementOfArray(int[] array)
        {
            return array[GetMaxIndexOfArray(array)];
        }


        //3. Find the index of the minimum element of the array
        static int GetMinIndexOfArray(int[] array)
        {
            int firstElement = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < firstElement)
                {
                    firstElement = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        //4. Find the index of the maximum element of the array
        static int GetMaxIndexOfArray(int[] array)
        {
            int firstElement = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > firstElement)
                {
                    firstElement = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }


        //5. Calculate the sum of array elements with odd indices
        static int GetSumOddIndices(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i+=2)
            {
                    sum += array[i];
            }

            return sum;
        }


        //6. Make an array reverse (an array in the opposite direction)
        static int[] GetReverse(int[] array)
        {
            int count = 1;
            int[] newArray = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - count];
                count++;
            }
           
            return newArray;
        }


        //7. Count the number of odd array elements
        static int GetCountOddElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }


        //8. Swap the first and second half of the array, for example, for an array of 1 2 3 4, the result is 3 4 1 2, or for 1 2 3 4 5 -> 4 5 3 1 2.
        static int[] SwapArray(int[] array)
        {
            int half = array.Length - array.Length / 2;

            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[half]);
                half++;
            }

            return array;
        }

        //9. Sort the array in ascending order in one of the ways: bubble (Bubble), selection (Select) or inserts (Insert))
        // Use metod "Sort"
        static int[] SortBubble(int[] array)
        {
            Sort(array);
                 
            return array;
        }


        //10. Sort the array in descending order in one of the ways (different from the method in the 9th task): bubble (Bubble), selection (Select) or inserts (Insert))
        // Use my metod GetReverse
        static void SortInsertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int element = array[i];
                int flag = 0;
                
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (element < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = element;
                    }
                    else flag = 1;
                }
            }
        }

        static int[] DescendingOrder(int[] array)
        {
            SortInsertion(array);

            return GetReverse(array);
        }
    }
}

       
