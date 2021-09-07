using System;
using System.Collections.Generic;
using System.Diagnostics;

// Comment 2 to demo on Github
// Hello from Manish
namespace L2_Algorithms_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array examples
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

            int[] ExampleArray = new int[5];
            ExampleArray[0] = 0;
            ExampleArray[1] = 1;

            Debug.WriteLine(ExampleArray[0]);
            Debug.WriteLine(ExampleArray[1]);
            Debug.WriteLine(ExampleArray[2]); // what to expect here?

            //Alternate forms of initialization
            string[] weekDays1 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Exercise: print the element with content "Thu"
            Debug.WriteLine(weekDays2[4]);

            // multi-diemnsional arrays
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

            int[,] Array2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // What will this print?
            Debug.WriteLine(Array2D[3, 1]);

            // Exercise 1: Create a 2D array of strings - 4 rows and 3 columns
            // each row to contain related colors (e.g. "red", "orange", "brown")

            // Exercise 2: Print each row


            // Hash tables/ Dictionaries
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.8
            // May need to add Using System.Collections.Generic

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // Add some key value pairs to the dictionary
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // Why do get an error below? 
            // openWith.Add("rtf", "word.exe");

            // How can we fix the error?



            // The key is used to index values 
            Debug.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // The values associated with a key can be changed
            openWith["rtf"] = "winword.exe";
            Debug.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // Delete item at key
            openWith.Remove("doc");

            // Exercise 3: Create a new dictionary called CourseEnrollments
            // Use strings as the key type and int as the value type
            // Populate the dictionary with 3 course names (e.g. 'ISM 6225') as keys,
            //  and the corresponding enrollments as values.
            // Print the enrollments for one of the courses
            // Check if the dictionary has enrollments information for a course
            // Replace information about a course with information for another course

            DataStructuresIntroduction.ComplexityDemo();
        }
    }
}