using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
  public class VideoPlayer : APlayer
  {
    private static VideoPlayer _vp = new VideoPlayer();

    private VideoPlayer() {}

    // public static VideoPlayer GetInstance()
    // {
    //   return _vp;
    // }

    public static VideoPlayer Instance
    {
      get
      {
        return _vp;
      }
    }
  }
}
