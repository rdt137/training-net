using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
  public class AudioPlayer : APlayer
  {
    private static AudioPlayer _ap = new AudioPlayer();
    private AudioPlayer() {}    

    // public static AudioPlayer GetInstance()
    // {
    //   return _ap;
    // }

    public static AudioPlayer Instance
    {
      get
      {
        return _ap;
      }
    }
  }
}
