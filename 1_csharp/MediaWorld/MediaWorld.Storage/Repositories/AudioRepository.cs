using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository
  {
    private static readonly List<AMedia> _lib = FileAdapter.Read(null) as List<AMedia>;

    // public static AudioRepository(IEnumerable<AMedia> enumerable)
    // {
    //   _lib = enumerable;
    // }

    public IEnumerable<AMedia> List()
    {
      return _lib;
    }
  }
}