using System;
using sc = System.Console;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string response = "";
      while (response != "Hello World")
      {
        sc.Write("Enter 'Hello World': ");
        response = sc.ReadLine();
        sc.WriteLine("You wrote {0}", response);
        if (response != "Hello World")
        {
          sc.WriteLine("Wrong input. Try again :(");
        }
      }
      sc.WriteLine("Great Job!");
    }
  }
}