using System;

namespace FizzBuzz
{
  class Program
  {
    static int num1 = 3;
    static int num2 = 5;

    static void Main(string[] args)
    {
      int num = ReturnNumber();
      //var fb = GetNum(num);
      var fb = GetNum(num);
      PrintFizzBuzz(fb);
      
    }

    public static int[] GetNum(int i)
    {      
      int[] fb = new int[]{0, 0, 0};

      for(int j = 1; j <= i; j++)
      {
        if((j % num1 == 0) && (j % num2 == 0))
        {
          Console.WriteLine("{0} \tFizzBuzz", j);
          fb[2] += 1;
        }
        else if(j % num2 == 0)
        {
          Console.WriteLine("{0} \tBuzz", j);
          fb[1] += 1;
        }
        else if(j % num1 == 0)
        {
          Console.WriteLine("{0} \tFizz", j);
          fb[0] += 1;
        }
        else
        {
          Console.WriteLine(j);
        }
      }

      return fb;
    }

    public static int ReturnNumber()
    {
      Console.Write("Enter Integer: ");
      try
      {
        return int.Parse(Console.ReadLine());
      }
      catch(Exception)
      {
        return 0;
      }      
    }

    public static void PrintFizzBuzz(int[] fb)
    {
      Console.WriteLine("");
      Console.WriteLine("{0} of Fizz", fb[0]);
      Console.WriteLine("{0} of Buzz", fb[1]);
      Console.WriteLine("{0} of FizzBuzz", fb[2]);
    }
  }
}
