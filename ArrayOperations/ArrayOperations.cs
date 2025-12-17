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

            PrintSectionHeader("BasicArrayOperations");
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
            PrintSectionFooter("BasicArrayOperations");
        }
        public static void ArraySearching()
        {
            int[] nums = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            PrintSectionHeader("ArraySearching");

            Console.WriteLine("Array Searching:");
            Console.WriteLine("Original Array: " + string.Join(", ", nums));
            
            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Linear Search using for loop");
            
            int target = 70;
            int index = -1;
            
            for(int i=0;i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"Linear Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Linear Search using Array.IndexOf");
            index = Array.IndexOf(nums, target);
            Console.WriteLine($"Linear Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Linear Search using Array.FindIndex");
            index = Array.FindIndex(nums, n => n == target);
            Console.WriteLine($"Linear Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Linear Search using Array.Find");
            int foundValue = Array.Find(nums, n => n == target);
            Console.WriteLine($"Linear Search: Element found is {foundValue}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Linear Search using Array.Exists");
            bool exists = Array.Exists(nums, n => n == target);
            Console.WriteLine($"Linear Search: Element {target} exists: {exists}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("first and last index using lastindexof and indexof");
            int[] numsWithDuplicates = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 70, 70 };
            int firstIndex = Array.IndexOf(numsWithDuplicates, target);
            int lastIndex = Array.LastIndexOf(numsWithDuplicates, target);
            Console.WriteLine($"First Index of {target}: {firstIndex}");
            Console.WriteLine($"Last Index of {target}: {lastIndex}");

            
            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Find and findall using predicates");
            int found = Array.Find(nums, n => n == target);
            int[] foundAll = Array.FindAll(nums, n => n >= 50);
            Console.WriteLine($"Find: Element found is {found}");
            Console.WriteLine("FindAll: Elements found are " + string.Join(", ", foundAll));


            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Binary Search using Array.BinarySearch");
            Array.Sort(nums);
            index = Array.BinarySearch(nums, target);
            Console.WriteLine($"Binary Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Binary Search using custom implementation");
            Array.Sort(nums);
            int BinarySearch(int[] array, int targetValue)
            {
                int left = 0;
                int right = array.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (array[mid] == targetValue)
                        return mid;
                    if (array[mid] < targetValue)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                return -1;
            }
            index = BinarySearch(nums, target);
            Console.WriteLine($"Binary Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Binary Search using LINQ");
            Array.Sort(nums);
            index = System.Linq.Enumerable.ToList(nums).BinarySearch(target);
            Console.WriteLine($"Binary Search: Element {target} found at index {index}");

            Console.WriteLine(new string('─', 80));
            Console.WriteLine("Binary Search using custom recursive implementation");
            int RecursiveBinarySearch(int[] array, int targetValue, int left, int right)
            {
                if (left > right)
                    return -1;
                int mid = left + (right - left) / 2;
                if (array[mid] == targetValue)
                    return mid;
                if (array[mid] < targetValue)
                    return RecursiveBinarySearch(array, targetValue, mid + 1, right);
                else
                    return RecursiveBinarySearch(array, targetValue, left, mid - 1);
            }
            index = RecursiveBinarySearch(nums, target, 0, nums.Length - 1);
            Console.WriteLine($"Binary Search: Element {target} found at index {index}");

            PrintSectionFooter("ArraySearching");
        }

        private static void PrintSectionHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 80));
            Console.WriteLine($" Start of {title}");
            Console.WriteLine(new string('=', 80));
        }

        private static void PrintSectionFooter(string title)
        {
            Console.WriteLine(new string('=', 80));
            Console.WriteLine($" End of {title}");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine();
        }

    }
}
