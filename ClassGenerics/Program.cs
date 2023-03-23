namespace ClassGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perform Class Generics");
            // Create an array with a mix of integer, double, and char elements
            object[] arr = new object[] { 1, 2.0, 'a', 3, 4.0, 'b' };

            // Print the original array
            Console.WriteLine("Original array: " + string.Join(", ", arr));

            // Create a DeleteArray instance that can handle objects
            DeleteArray<object> deleteObj = new DeleteArray<object>();

            // Delete the 'a' character from the array
            deleteObj.Delete(ref arr, 2.0);

            // Print the modified array
            Console.WriteLine("Array after deleting 2.0: " + string.Join(", ", arr));

            // Delete the 'b' character from the array
            deleteObj.Delete(ref arr, 'b');

            // Print the final array
            Console.WriteLine("Array after deleting 'b': " + string.Join(", ", arr));
        }
    }
}