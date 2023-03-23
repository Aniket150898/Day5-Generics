namespace WithGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array with a mix of integer, double, and char elements
            object[] arr = new object[] { 1, 2.0, 'a', 3, 4.0, 'b' };

            // Print the original array
            Console.WriteLine("Original array: " + string.Join(", ", arr));

            // Delete the 'a' character from the array
            DeleteArray.Delete(ref arr, 'a');

            // Print the modified array
            Console.WriteLine("Array after deleting 'a': " + string.Join(", ", arr));

            // Delete the 'b' character from the array
            DeleteArray.Delete(ref arr, 'b');

            // Print the final array
            Console.WriteLine("Array after deleting 'b': " + string.Join(", ", arr));
        }
    }
}