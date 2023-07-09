using System;

namespace Merging1Project
{
    class Program
    {
        /* a[low1]...a[up1] and a[low2]...a[up2] merged to temp[low1]...temp[up2] */
        public static void Merge(int[] a, int[] temp, int low1, int up1, int low2, int up2)
        {
            int i = low1;
            int j = low2;
            int k = low1;

            while ((i <= up1) && (j <= up2))
            {
                if (a[i] <= a[j])
                    temp[k++] = a[i++];
                else
                    temp[k++] = a[j++];
            }

            while (i <= up1)
                temp[k++] = a[i++];

            while (j <= up2)
                temp[k++] = a[j++];
        }
        
        static void Main(string[] args)
        {
            int i;
		    int[] a = {1,3,5,7,  2,4,6,9,11,14};
		    int[] temp = new int[20];
			
		    Merge(a, temp, 0, 3, 4, 9);   // where 0, 3, 4 and 9 are indexes of low1, up1, low2 and up2
		
		    Console.WriteLine("Array a is : ");
		    for(i = 0; i <= 9; i++)
			    Console.Write(a[i] + " ");
		    Console.WriteLine();
		
		    Console.WriteLine("Merged array temp is : ");
		    for( i = 0; i <= 9; i++ )
			    Console.Write(temp[i] + " ");
		    Console.WriteLine();
        }
    }
}
