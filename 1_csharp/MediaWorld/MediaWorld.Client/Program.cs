using System;
using System.Linq;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;
using MediaWorld.Storage.Adapters;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client
{
  internal class Program
  {
    private static readonly AudioRepository _ar = new AudioRepository();
    private static void Main(string[] args)
    {
      
      //PlayAudio();
      //PlayVideo();
      PlayBook();
    }

    private static void PlayBook()
    {
      var b = new Book();

      // b.Read(HowToRead.Upper);
      // b.ReadAction((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
      // b.ReadFunction((string s) => { Console.WriteLine(s.ToUpperInvariant()); return string.Empty; });
      // b.ReadDelegate((string s) => { Console.WriteLine(s.ToLowerInvariant()); });

      // Delegate part 2
      // b.ReadDelegate(UsingCaseDelegate);
      // b.ReadDelegate2(UsingCaseDelegate2);

      // Event
      b.BookEvent += UseEvent;
      b.Open();
    }

    public static void UseEvent(string s)
    {
      Console.WriteLine("We heard you");
    }

    private static void UsingCaseDelegate(string s)
    {
      Console.WriteLine(s);
    }

    private static string UsingCaseDelegate2()
    {
      return "Delegate Rules!";
    }


    private static void PlayAudio()
    {
      //AudioPlayer ap = new AudioPlayer();
      //Console.WriteLine(ap);
      //var ap = AudioPlayer.GetInstance();
      
      var ap = AudioPlayer.Instance;
      //var s = new Song();
      // ap.Play(s);
      // ap.Stop(s);

      
      
      //var ar = new AudioRepository();
      var ar = new AudioRepository();
      //var audio = ar.List();
      var ar2 = new AudioRepositoryGeneric<AAudio>();

      try
      {
        foreach (var item in ar.List())
        {
          ap.Play(item);          
        }
      }
      catch(NullReferenceException)
      {
        Console.WriteLine("No playlist :( ");
      }
      catch(IndexOutOfRangeException)
      {
        Console.WriteLine("No song :( ");
      }
      catch(Exception e)
      {
        throw new Exception("Error", e);
      }
      finally
      {
        GC.Collect();        
      }
    }

    private static void PlayVideo()
    {
      //var vp = VideoPlayer.GetInstance();
      var vp = VideoPlayer.Instance;
      var m = new Movie();
      // vp.Play(m);
      // vp.Stop(m);   


    }
  }
}
