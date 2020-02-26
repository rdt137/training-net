using System;
using static System.Console;

namespace Digimon
{
  
  internal class Digimon
  {
    
  }
  internal class Program
  {
    private static void Main(string[] args)
    {
      //var p = new Program();
      Fight(null, null);
    }

    public static void Fight(Digimon a, Digimon b)
    {
      WriteLine("{0} fights {1}", a, b);
    }
  }    
}
