﻿using System;

class Program
{
        public static int Search(int[] a, int n, int searchValue)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (a[i] >= searchValue)
                    break;
            }
            if (a[i] == searchValue)
                return i;
            else
                return -1;
        }

        static void Main(string[] args)
        {
            int i, n, searchValue, index;

            int[] a = new int[100];

            Console.Write("Enter the number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in sorted order - ");
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the search value : ");
            searchValue = Convert.ToInt32(Console.ReadLine());

            index = Search(a, n, searchValue);

            if (index == -1)
                Console.WriteLine("Value " + searchValue + " not present in the array");
            else
                Console.WriteLine("Value " + searchValue + " present at index " + index);
        }
}

