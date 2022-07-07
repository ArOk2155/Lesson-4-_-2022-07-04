using System;

namespace Lesson_4___2022_07_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetMinElementOfArray(RandomArray(10)));
            //Console.WriteLine(GetMaxElementOfArray(RandomArray(10)));
            //Console.WriteLine(GetMinIndexOfArray(RandomArray(10)));
            //Console.WriteLine(GetMaxIndexOfArray(RandomArray(10)));
            //Console.WriteLine(GetSumOddIndices(RandomArray(5)));
            //GetReverse(RandomArray(5));
            //Console.WriteLine(GetCountOddElements(RandomArray(5)));
            //SwapArray(RandomArray(6));
            //SortBubble(RandomArray(6));
            //DescendingOrder(RandomArray(6));

        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
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

            PrintArray(array);

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
            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }             
            }

            return result;
        }


        //2. Find the maximum element of an array
        static int GetMaxElementOfArray(int[] array)
        {
            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }

            return result;
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

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }


        //6. Make an array reverse (an array in the opposite direction)
        static int[] GetReverse(int[] array)
        {
            var count = 1;
            var newArray = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - count];
                count++;
            }
           
            //PrintArray(newArray);
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
            int lenCenter = array.Length / 2;

            int half = array.Length - lenCenter;

            for (int i = 0; i < lenCenter; i++)
            {
                Swap(ref array[i], ref array[half]);
                half++;
            }

            //PrintArray(array);
            return array;
        }

        //9. Sort the array in ascending order in one of the ways: bubble (Bubble), selection (Select) or inserts (Insert))
        // Use metod "Sort"
        static int[] SortBubble(int[] array)
        {
            Sort(array);
            
            //PrintArray(array);          
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
            //PrintArray(GetReverse(array));

            return GetReverse(array);
        }
    }
}

       
