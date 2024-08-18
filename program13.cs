using System;
using System.Linq;
using System.Collections.Generic;

// Define a class named LinqExercise13
class LinqExercise13
{
    // Main method, the entry point of the program
    static void Main(string[] args)
    {
        string[] arr1; // Declare a string array named arr1
        int n, i; // Declare integer variables n and i

        // Display information about the program
        Console.Write("\nLINQ : Convert a string array to a string : ");
        Console.Write("\n------------------------------------------\n");

        // Ask the user for the number of strings to store in the array
        Console.Write("Input number of strings to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());
        arr1 = new string[n]; // Initialize arr1 with size n

        // Prompt the user to input strings for the array
        Console.Write("Input {0} strings for the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Element[{0}] : ", i);
            arr1[i] = Console.ReadLine(); // Store user input in the array
        }

        // Join the elements of the array into a single string separated by ", "
        string newstring = String.Join(", ", arr1
                            .Select(s => s.ToString())
                            .ToArray());

        // Display the new string created from the elements of the array
        Console.Write("\nHere is the string below created with elements of the above array :\n\n");
        Console.WriteLine(newstring);
        Console.Write("\n");
        Console.ReadLine(); // Wait for user input before closing the program
    }
}
