using System;

namespace Ex_7
{
    // Write a program, which creates an array of 20 elements of type integer and initializes
    // each of the elements with a value equals to the index of the element multiplied by 5.
    // Print the elements to the console.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }

    }
}
