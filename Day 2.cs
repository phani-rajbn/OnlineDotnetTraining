using System;
class TempClass
{
    static double getDouble(string question)
    {
        //Console.WriteLine(question);
        //return double.Parse(Console.ReadLine());
        return double.Parse(getString(question));
    }

    static string getString(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
    }

    static void processMenu(string choice, double v1, double v2)
    {
        switch (choice)
        {
            case "Add":
                Console.WriteLine("The added value is " + (v1 + v2));
                break;
            case "Sub":
                Console.WriteLine("The Subtracted value is " + (v1 - v2));
                break;
            case "Mul":
                Console.WriteLine("The multiplied value is " + (v1 * v2));
                break;
            case "Div":
                Console.WriteLine("The divided value is " + (v1 / v2));
                break;
        }
    }
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter the Age");
        //int age = int.Parse(Console.ReadLine());//storing as string
        //Console.WriteLine("The age is " + age);//displaying it here...
        ////If UR data has to be computed, then U should store it in the format that it holds good...
        //Console.WriteLine("The no of years left for my retirement is " + (60 - age));

        //All data types in C# are based on .NET Types. There are 2 types of data in .NET: Primitive(Value) and Reference types(Classes, Arrays where the data is stored in a seperate place called heap inside the process). Value types are primitive types stored as structs: byte, short, int, long, float, double, decimal, char, bool, enum....
        string canQuit;
        do
        {
            double v1 = getDouble("Enter v1");
            double v2 = getDouble("Enter v2");

            string choice = getString("Enter the choice of operation: Add, Sub, Mul or Div");

            processMenu(choice, v1, v2);  
            canQuit = getString("Do U want to compute another operation? Press Y or N");
        } while (canQuit != "N");
    }
}