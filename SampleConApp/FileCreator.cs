using System;
using System.IO;
namespace SampleConApp
{
  class FileCreator
  {
    static void Main(string[] args)
    {
      var filename = "../../Example.dat";
      if(!File.Exists(filename))
      {
        Console.WriteLine("Wrong file");
        return;
      }
      StreamReader reader = new StreamReader(filename);
      var content = reader.ReadToEnd();
      reader.Close(); ;
      StreamWriter writer = new StreamWriter("Copy.dat");
      writer.Write(content);
      writer.Close();

    }
  }
}
