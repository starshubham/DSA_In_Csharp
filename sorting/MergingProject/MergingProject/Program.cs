﻿using System;

namespace MergingProject
{
    class Program
    {
        public static void Merge(int[] a1, int[] a2, int[] temp, int n1, int n2)
        {
            int i = 0, j = 0, k = 0;

            while ((i <= n1-1) && (j <= n2-1))
            {
                if (a1[i] < a2[j])
                    temp[k++] = a1[i++];
                else
                    temp[k++] = a2[j++];
            }

            /*copy remaining elements of a1, if array a2 finished */
            while (i <= n1 - 1)
                temp[k++] = a1[i++];

            /*copy remaining elements of a2, if array a1 finished */
            while (j <= n2 - 1)
                temp[k++] = a2[j++];
        }

        static void Main(string[] args)
        {
            int i,n1,n2;
		    int[] a1 = new int[20];
		    int[] a2 = new int[20];
		    int[] temp = new int[40];
				
		    Console.Write("Enter the number of elements in array a1 : ");
		    n1 = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("Enter elements in sorted order : " );
		    for( i = 0; i < n1; i++)
		    {
			    Console.Write("Enter element " + (i+1) + " : ");
			    a1[i] = Convert.ToInt32(Console.ReadLine());
		    }
		
		    Console.Write("Enter the number of elements in array a2 : ");
		    n2 = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("Enter elements in sorted order : ");
		    for( i = 0; i < n2; i++ )
		    {
			    Console.Write("Enter element " + (i+1) + " : ");
			    a2[i] = Convert.ToInt32(Console.ReadLine());
		    }
		
		    Merge(a1, a2, temp, n1, n2);
						
		    Console.WriteLine("Merged array temp is : ");
		    for( i = 0; i < n1+n2; i++ )
			    Console.Write(temp[i] + " ");
		    Console.WriteLine();
		}
    }
}
