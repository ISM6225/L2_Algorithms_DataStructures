using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace L2_Algorithms_DataStructures
{
    public class DataStructuresIntroduction
    {
        public static void ComplexityDemo()
        {
            // Arrays example
            int[] numbersArray = new int[] { 100, 200, 400, 800 };

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Debug.WriteLine(numbersArray[i]);
            }

            // Lists example
            List<int> numbersList = new List<int>();
            numbersList.Add(100);
            numbersList.Add(200);
            numbersList.Add(400);
            numbersList.Add(800);

            for (int i = 0; i < numbersList.Count; i++)
            {
                Debug.WriteLine(numbersList[i]);
            }

            // Dictionaries example
            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();
            numbersDictionary.Add(1, 100);
            numbersDictionary.Add(2, 200);
            numbersDictionary.Add(3, 400);
            numbersDictionary.Add(4, 800);

            // Hack, using Linq, to maintain parallel with Arrays and Lists examples
            int[] keysArray = numbersDictionary.Keys.ToArray<int>();

            for (int i = 0; i < numbersDictionary.Count; i++)
            {
                Debug.WriteLine(numbersDictionary[keysArray[i]]);
            }

            // Search operations
            // We will populate an array and a dictionary with some random numbers
            //  and compare search times

            // initialize
            int numbersToCheck = 100000;
            Random random = new Random();
            int n;

            // our data structures
            int[] numbersSearchArray = new int[numbersToCheck];
            Dictionary<int, int> numbersSearchDictionary = new Dictionary<int, int>();

            // populate data
            for (int i = 0; i < numbersToCheck; i++)
            {
                n = random.Next();
                numbersSearchArray[i] = n;
                numbersSearchDictionary.TryAdd(n, n);
            }

            Debug.WriteLine("Elements in the dictionary = " + numbersSearchDictionary.Count());

            // now, time the searches
            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < numbersToCheck; i++)
            {
                findInArray(random.Next(), numbersSearchArray);
            }

            watch.Stop();
            long arraySearchTimeMs = watch.ElapsedMilliseconds;

            watch.Reset();
            watch.Start();

            for (int i = 0; i < numbersToCheck; i++)
            {
                numbersSearchDictionary.TryGetValue(random.Next(), out n);
            }

            watch.Stop();
            long dictionarySearchTimeMs = watch.ElapsedMilliseconds;

            Debug.WriteLine("Array search took " + arraySearchTimeMs + " mSecs");
            Debug.WriteLine("Dictionary search took " + dictionarySearchTimeMs + " mSecs");
        }

        /// <summary>
        /// Method to find a number in an array
        /// The method returns 1 if the number is found
        ///   Else, it returns -1
        /// </summary>
        /// <param name="numberToFind">Number to search in the array</param>
        /// <param name="numbersArray">The array of numbers</param>
        /// <returns>index or -1</returns>
        public static int findInArray(int numberToFind, int[] numbersArray)
        {
            bool found = false;
            int counter = 0;

            while (!found && counter < numbersArray.Length)
            {
                if (numbersArray[counter] == numberToFind)
                {
                    return 1; // counter;
                }
                else
                {
                    counter = counter + 1;
                }
            }

            // Number was not found
            return -1;
        }
    }
}