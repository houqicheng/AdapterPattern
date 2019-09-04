using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    class OperationAdapter:ScoreOperation
    {
        private QuickSortClass sortObj;
        private BinarySearchClass searchObj;
        public OperationAdapter()
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
        }

        public int[] Sort(int[] array)
        {
            return sortObj.QuickSort(array);            
        }

        public int Search(int[] array, int key)
        {
           return searchObj.BinarySearch(array,key);
        }
    }
}
