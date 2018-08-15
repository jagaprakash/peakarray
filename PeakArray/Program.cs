using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 88,555, 55,
                     4, 1, 0};
            int n = arr.Length;
            Console.WriteLine("Index of a peak " +
                                     "point is " +
                                findPeak(arr, n));
            Console.ReadLine();
        }

        static int FindPeakArray(int[] arr, int high, int low, int n)
        {
            //Find the middle item index in the array
            int mid = low + (high - low) / 2;

            //Compare middle elements with neighbours (if exists)
            if ((mid == 0 || arr[mid - 1] <= arr[mid]) && (mid == n - 1 || arr[mid + 1] <= arr[mid]))
            {
                return arr[mid];
            }

            // If middle element is not 
            // peak and its left neighbor
            // is greater than it,then 
            // left half must have a 
            // peak element
            else if ((mid > 0 || arr[mid - 1] > arr[mid]))
            {
                return FindPeakArray(arr, low, (mid - 1), n);
            }

            // If middle element is not 
            // peak and its right neighbor
            // is greater than it, then 
            // right half must have a peak
            // element
            else
            {
                return FindPeakArray(arr, (mid + 1), high, n);
            }
        }

        // A wrapper over recursive 
        // function findPeakUtil()
        static int findPeak(int[] arr,
                            int n)
        {
            return FindPeakArray(arr, 0, n - 1, n);
        }
    }
}
