using System;

namespace DeletingAtStatofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            int length = 0;

            for(int i = 0; i<6; i++)
            {
                intArray[length] = i;
                length++;
            }
            Console.WriteLine("Original Array: ");
            foreach(var i in intArray)
            {
                Console.WriteLine(i);
            }

            // moving to the first position of the array
            for (int i = 1; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }

            length--;

            Console.WriteLine("New Array:");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }


        }
    }
}
