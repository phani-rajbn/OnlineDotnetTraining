//using System;//System is a group that contains classes to do min work for .NET development..
//Console represents Command prompt...
using System;//namespace is conceptual group of classes created to avoid naming conflicts...

namespace SampleConApp
{
  class MainClass
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello world");//writes the text and retains the same line...
      //Console.WriteLine("Test13");//Writes a text on the console and creates a new line...

      Console.WriteLine("Enter UR Name");
      string name = Console.ReadLine();//Reads the text entered by the User and returns a string variable that represents it..
      Console.WriteLine("The name enterd is " + name);
    }
  }
  /*
    Create a program to display information about URself...
    Create a program to take inputs from the user about his name, address, phone, salary..

  */
}
