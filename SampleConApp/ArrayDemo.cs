using System;

namespace SampleConApp
{
  class ArrayDemo
  {
    static void Main(string[] args)
    {
      //Array is a sp type of data type which can store fixed no of values sequentially using a sp syntax...
      string[] fruits = new string[] { "Apple", "Mango", "Orange" };
      //for loop is used to execute a set of statements for a specific no of times.
      //for (int i = 0; i < 3; i++)
      //{
      //  Console.WriteLine("Enter the fruit name to add");
      //  fruits[i] = Console.ReadLine();
      //}
      //foreach is an optimized loop that allows to access each item inside a array. It is forwardonly and readonly.
      foreach (string item in fruits)
      {
        Console.Write(item +" ");
      }
      Console.WriteLine("The Second fruit is " + fruits[1]);

      //Jagged arrays: Array of arrays is called as Jagged arrays. Here U will have n of rows and each row will have variable no of columns. Consider Jagged arrays as array of arrays. Eg: A School has an array of classrooms and each classroom will have variable no of students.

      int[][] school = new int[4][];//4 rows
      school[0] = new int[] { 3, 4, 5, 6 };
      school[1] = new int
        
        
        
        
        [] { 3, 4, 5 };
      school[2] = new int[] { 6, 7, 8, 9, 0, 7, 6, 4 };
      school[3] = new int[] { 6, 7, 8, 9, 0 };

      for (int i = 0; i < school.Length; i++)
      {
        foreach (int val in school[i]) Console.Write(val + " ");
        Console.WriteLine();
      }
      string[] cloned = fruits.Clone() as string[];
      foreach(var fruit in cloned)
        Console.WriteLine(fruit);
      Console.WriteLine("The total fruits with us is " + fruits.Length);
      Console.WriteLine("The no of dimensions of this array is " + fruits.Rank);
      //Array limitations: Fixed no of elements, U cannot add or remove any element once created. 
      //Arrays are objects of a class called System.Array defined in .NET Framework. U get properties(Data) and methods(Functions) about UR array at runtime...
    }
  }
}
