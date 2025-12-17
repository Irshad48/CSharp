using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    public static class ArrayOperations
    {
        public static void BasicArrayOperations()
        {
            int[] num = new int[5];
            int[] initializedArray = { 1, 2, 3, 4, 5 };
            int[] sizedArray = new int[3] { 10, 20, 30 };

            Console.WriteLine("Basic Array Operations:");
            Console.WriteLine("Initialized Array: " + string.Join(", ", initializedArray));
            Console.WriteLine("Sized Array: " + string.Join(", ", sizedArray));

            //Access & Modify Elements
            num[0] = 100;
            Console.WriteLine("Modified First Element of num: " + num[0]);
            int value = num[0];
            Console.WriteLine("Accessed First Element of num: " + value);

            //Array Properties - Length & Rank
            Console.WriteLine($"Length: {num.Length}");
            Console.WriteLine($"Rank: {num.Rank}");


            // Example implementation
            Console.WriteLine("Iterating over initializedArray:");  
            foreach (var number in initializedArray)
            {
                System.Console.WriteLine(number);
            }

           
        }
    }
}
