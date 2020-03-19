using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulation
{
  class Program
  {
    static string sReverse;
    
    static void Main(string[] args)
    {
      string Str = GetString();
      var data = GetData(Str);

      Console.WriteLine(data[0]);
      Console.WriteLine(data[1]);
      Console.WriteLine(data[2]);
      Console.WriteLine(data[3]);
      Console.WriteLine(data[4]);
      Console.WriteLine(sReverse);

    }

    static string GetString()
    {
      Console.Write("Enter String: ");
      return Console.ReadLine();
    }

    public static int[] GetData(string s)
    {
      int[] Data = new int[] { 0, 0, 0, 0, 0};

      //var Consonants = new HashSet<char>{ 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'w', 'z' };
      var Vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u' };

      string sLower = s.ToLower();
      Data[0] = s.Length;

      for(int i = 0; i < sLower.Length; i++)
      {
        if(!Vowels.Contains(sLower[i])) 
        {
          Data[1] += 1;
        }
      }

      for(int i = 0; i < sLower.Length; i++)
      {
        if(Vowels.Contains(sLower[i]))
        {
          Data[2] += 1;
        }
      }

      foreach(string word in s.Split(" "))
      {
        Data[3] += 1;
      }
      
      string str = s.Replace(" ", String.Empty);
      string uniqueString = new String(str.Distinct().ToArray());
      Data[4] += str.Length - uniqueString.Length;

      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      sReverse = new string(arr);

      

    
      return Data;
    }
  }
}

