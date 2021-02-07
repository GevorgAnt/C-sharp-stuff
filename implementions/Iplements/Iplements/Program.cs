using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;

namespace Iplements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 8, 16, 2, 36, 89, 999, 1, 2, 5, 7 };
           
        }

        // merge sort algorythm
        static void MergSort(int[] arr, int r, int m, int l)
        {

            int n1 = m - r + 1;
            int n2 = l - m;

            int[] left = new int[n1];
            int[] right = new int[n2];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[r + i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[m + i + 1];
            }
            int n = 0, j = 0, k = r;

            while (n < n1 && j < n2)
            {
                if (left[n] <= right[j])
                {
                    arr[k] = left[n];
                    n++;
                }
                else
                {
                    arr[k] = right[j];

                    j++;
                }
                k++;
            }
            while (n < n1)
            {
                arr[k] = left[n];
                n++; k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++; k++;
            }

        }

        static void Merge(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                Merge(arr, l, m);
                Merge(arr, m + 1, r);

                // Merge the sorted halves 
                MergSort(arr, l, m, r);
            }
        }

        //find sub array with max val in array
        static int[] ArrayCrossSub(int[] arr, int low, int mid, int high)
        {
            int lefSum = int.MinValue;
            int rightSum = int.MinValue;
            int sum = 0;
            int lefindex = 0;
            int rightindex = 0;
            int i = 0;
            int j = 0;
            for (i = mid; i >= low; --i)
            {
                sum += arr[i];
                if (sum > lefSum)
                {
                    lefSum = sum;
                    lefindex = i;
                }
            }

            sum = 0;

            for (j = mid + 1; j <= high; j++)
            {
                sum += arr[j];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    rightindex = j;
                }
            }


            return new int[] { lefindex, rightindex, lefSum + rightSum };


        }

        static int[] Maxsubarr(int[] arr, int low, int high)

        {

            if (low == high)
                return new int[] { low, high, arr[low] };
            else
            {
                int mid = (low + high) / 2;

                int[] leftarr = Maxsubarr(arr, low, mid);
                int[] rightarr = Maxsubarr(arr, mid + 1, high);
                int[] middlearr = ArrayCrossSub(arr, low, mid, high);

                if (leftarr[leftarr.Length - 1] > rightarr[rightarr.Length - 1] && leftarr[leftarr.Length - 1] > middlearr[middlearr.Length - 1])
                    return leftarr;
                else if (rightarr[rightarr.Length - 1] > leftarr[leftarr.Length - 1] && rightarr[rightarr.Length - 1] > middlearr[middlearr.Length - 1])
                    return rightarr;
                else
                    return middlearr;
            }
        }

        static int Maxsubarrlinear(int[] arr, int low, int high)

        {
            int firstindex = 0;

            int sum = int.MinValue;
            int maxval = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxval += arr[i];
                if (maxval > sum)
                    sum = maxval;

                if (maxval < 0)
                {
                    maxval = 0;
                }


            }




            return sum;
        }

        //heap sort

        static void Max_HeapSort(int[] arr, int lenght, int i)
        {
            int left = i * 2 + 1;
            int right = left + 1;
            int largest = i;
            if (left < lenght && arr[left] > arr[largest])
                largest = left;
            if (right < lenght && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Max_HeapSort(arr, lenght, largest);

            }

        }

        static void Build_Max_HeapSort(int[] arr)
        {
            for (int i = (arr.Length / 2) - 1; i >= 0; i--)
            {
                Max_HeapSort(arr, arr.Length, i);
            }
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Max_HeapSort(arr, i, 0);
            }


        }

        
       

        //quick sort
        static int Partition(int[] arr, int f, int l)
        {
            int temp;
            int rell = arr[l];
            int i = f - 1;

            for (int j = f; j < l; j++)
                if (arr[j] <= rell)
                {
                    i = i + 1;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            temp = arr[l];
            arr[l] = arr[i + 1];
            arr[i + 1] = temp;
            return i + 1;
        }
        static void QuickSort(int[] arr, int f, int l)
        {
            if (f < l)
            {
                int q = Partition(arr, f, l);
                QuickSort(arr, f, q - 1);
                QuickSort(arr, q + 1, l);
            }
        }

        //counting sort
        static int[] CountingSort(int[] arr, int k)
        {
            int[] sorted_arr = new int[arr.Length];
            int[] count = new int[k];
            /* for (int i = 0; i < count.Length; i++)
             {
                 count[i]=0;
             }*/
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sorted_arr[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }
            return sorted_arr;
        }
        
       



    }



}


