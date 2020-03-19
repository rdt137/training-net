using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepositoryGeneric<T> where T : AAudio
  {
    private static readonly List<T> _lib = FileAdapter.Read(null) as List<T>;

    public IEnumerable<T> List()
    {
      return _lib;
    }
  }
}