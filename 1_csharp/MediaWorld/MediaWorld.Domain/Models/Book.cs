using MediaWorld.Domain.Abstracts;
using System;
using System.Threading;

namespace MediaWorld.Domain.Models
{
  
  
  public class Book : AAudio
  {
    public delegate void CasingDelegate(string s);
    public delegate string CasingDelegate2();
    public event CasingDelegate BookEvent;
    
    public void Read(HowToRead r)
    {
      var text = "Read The Book";

      switch(r)
      {
        case HowToRead.Upper:
          Console.WriteLine(text.ToUpperInvariant());
          break;
        case HowToRead.Lower:
          Console.WriteLine(text.ToLowerInvariant());
          break;
      }
    }

    public void ReadAction(Action<string> d)
    {
      var text = "Read From Action";

      d(text);
    }

    public void ReadFunction(Func<string, string> d)
    {
      var text = "Read From Function";

      d(text);
    }

    public void ReadDelegate(CasingDelegate d)
    {
      var text = "Read From Delegate";

      d(text);
    }

    public void ReadDelegate2(CasingDelegate2 d)
    {
      Console.WriteLine(d());
      //d();
    }

    public void Open()
    {
      this.BookEvent("Someone opened a book");

      if(BookEvent != null)
      {
        var count = 0;
        
        while(count < 10)
        {
          this.BookEvent("Someone opened a book");
          Thread.Sleep(1000);
          count += 1;
        }
      }
    }
  }

  public enum HowToRead
  {
    Upper,
    Lower
  }
}