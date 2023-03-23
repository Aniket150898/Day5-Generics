namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Everyone,Performing Class, Method Generics Problems");
            //Defined Array
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

            Console.WriteLine("Original arrays:");
            Console.WriteLine(string.Join(",", intArray));
            Console.WriteLine(string.Join(",", doubleArray));
            Console.WriteLine(string.Join(",", charArray));

            DeleteArray.DeleteMethod(ref intArray, 2);
            DeleteArray.DeleteMethod(ref doubleArray, 3);
            DeleteArray.DeleteMethod(ref charArray, 4);

            Console.WriteLine("Arrays after deleting element at index 2, 3, and 4:");
            Console.WriteLine(string.Join(",", intArray));
            Console.WriteLine(string.Join(",", doubleArray));
            Console.WriteLine(string.Join(",", charArray));

            Console.ReadLine();
        }
    }
}