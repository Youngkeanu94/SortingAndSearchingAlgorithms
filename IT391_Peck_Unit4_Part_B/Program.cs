using System;
using System.Reflection;
using System.Linq;


namespace IT391_Peck_Unit4_Part_B
{
    internal class myProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*********Section 1 - Bubble Sort*********");
            Console.WriteLine();
            int[] studentGrades = { 65, 95, 75, 55, 56, 90, 98, 88, 97, 78 };
            myProgram testing = new myProgram();

            testing.bubbleSortArrayDes(studentGrades);
            Console.WriteLine("Bubble sort Descending");
            testing.printArrary(studentGrades);
            testing.bubbleSortArrayAsc(studentGrades);
            Console.WriteLine("Bubble Sort Ascending");
            testing.printArrary(studentGrades);

            //Part B section2


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********Section 2 - Quick Sort*********");
            Console.WriteLine();

            testing.quickSortArrayDes(studentGrades, 0, 9);
            Console.WriteLine("Quicksort Descending");
            testing.printArrary(studentGrades);

            testing.quickSortArrayAsc(studentGrades, 0, 9);
            Console.WriteLine("Quicksort Ascending");
            testing.printArrary(studentGrades);


            //Part B section 3

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********Section 3 - Sequential Search*********");
            Console.WriteLine();

            testing.SequentialSearch(testing.SortArrayAscReturned(studentGrades), 75);
            //Console.WriteLine("Index of 75 value in array is " + index.ToString());
            testing.SequentialSearch(testing.SortArrayAscReturned(studentGrades), 60);



            // section 4

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********Section 4 - Binary Search*********");
            Console.WriteLine();

            binarySearch(testing.SortArrayAscReturned(studentGrades), 0, 9, 56);

            binarySearch(testing.SortArrayAscReturned(studentGrades), 0, 9, 50);
        }

        public void bubbleSortArrayAsc(int[] x)
        {

            int temp = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sort Ascending");

        }

        public int[] SortArrayAscReturned(int[] x)
        {
            return x.OrderBy((a) =>a).ToArray();
        }

        public void bubbleSortArrayDes(int[] x)
        {
            int temp = 0;

                for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j] < x[j + 1])
                    {
                        temp = x[j + 1];
                        x[j + 1] = x[j];
                        x[j] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble Sort Descending");
        }


        public void quickSortArrayDes(int[] x, int low, int high)
        {
        
        if (x == null || x.Length == 0)
                return;
        if (low>= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];




            int i = low, j = high;
            while (i <= j)
            {
                while (x[i] > pivot)
                {
                    i++;
                }

                while (x[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                    //count = count + 1; //counts number of swaps made during sort
                }
            }


            //recursively sort two sub parts
            if (low < j)
                quickSortArrayDes(x, low, j);

            if (high > i)
                quickSortArrayDes(x, i, high);
        }


        public void quickSortArrayAsc(int[] x, int low, int high)
        {
            if (x == null || x.Length == 0)
                return;

            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            int pivot = x[middle];



           int i = low, j = high;
            while (i <= j)
            {
                while (x[i] < pivot)
                {
                    i++;
                }
                while (x[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    i++;
                    j--;
                }
            }
            //recursively sort two sub parts
            if (low < j)
                quickSortArrayDes(x, low, j);

            if (high > i)
                quickSortArrayDes(x, i, high);

        }

        public void SequentialSearch(int[] arr, int searchNumber)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchNumber)
                {
                    Console.WriteLine("The number " + searchNumber + " was found at index " + i + ".");
                    Console.WriteLine(searchNumber + " is in the array. We found it and we end the sequential search.");
                    break;
                }
                else
                {
                    Console.WriteLine(searchNumber + " is not at index " + i + ". And we continue our next iteration in for loop.");

                }
            }
            //return (i < arr.Length - 1) ? i : -1;
        }
        public static void binarySearch(int[] x, int lowerbound, int upperbound, int key)
        {
            int position;
            //counting comparisons
            //find subscript of middle position
            position = (lowerbound + upperbound) / 2;
            while ((x[position] != key) && (lowerbound <= upperbound))
            {
                if (x[position] > key)
                {
                    upperbound = position - 1;
                }
                else
                {
                    lowerbound = position + 1;
                }
                position = (lowerbound + upperbound) / 2;
            }

            if (lowerbound <= upperbound)
            {
                Console.WriteLine("The number " + x[position] + " was found at index " + position + ".");
                Console.WriteLine(x[position] + " is in the array. We found it and we end the binary search.");
            }
            else
            {
                Console.WriteLine(key + " is not in the array.");
            }
        }
        public void printArrary(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i] + " ");
            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }    
    }
    
}
