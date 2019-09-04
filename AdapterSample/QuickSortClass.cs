using System;       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    class QuickSortClass
    {
        public int[] QuickSort(int[] array)
        {
            Sort(array,0,array.Length-1);
            return array;
        }
        private void Sort(int[] array,int p,int r)
        {
            int q = 0;
            if (p<r)
            {
                q = Partition(array, p, r);
                Sort(array, p, q - 1);
                Sort(array, q + 1, r);
            }
        }

        private int Partition(int[] a, int p, int r)
        {
            int j = p - 1;
            int x = a[r];
            for (int i = p; i <= r-1; i++)
            {
                if (a[i] <= x)
                {
                    j++;
                    swap(a, j, i);
                }
            }
            swap(a, j + 1, r);
            return j + 1;
        }

        private void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
