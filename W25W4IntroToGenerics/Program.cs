namespace W25W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            object obj = num;   // boxing

            num = (int)obj;     // unboxing



            //if (AreEqual(5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");



            int[] intArray = { 4, 5, 6, 7, 8 };
            double[] doubleArray = { 3.3, 4.4, 5.5, 6.6 };
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };

            PrintArray<int>(intArray);
            PrintArray<double>(doubleArray);
            PrintArray<char>(charArray);
        }


        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("\n\nNumber of items: " + array.Length);

            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }



        // non-generic method
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
