using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithGenerics
{
    internal class DeleteArray
    {
        public static void Delete<T>(ref T[] arr, T item)
        {
            // Find the index of the item to delete
            int index = Array.IndexOf(arr, item);

            if (index >= 0)
            {
                // If the item is found, create a new array with one less element
                T[] newArr = new T[arr.Length - 1];

                // Copy the elements before the item to the new array
                Array.Copy(arr, 0, newArr, 0, index);

                // Copy the elements after the item to the new array
                Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);

                // Update the reference to the original array
                arr = newArr;
            }
        }
    }
}
