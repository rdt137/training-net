using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public delegate void CasingDelegate(string s);
  public class Song : AAudio
  {
    public void ReadDelegate(CasingDelegate d)
    {
      var text = "Read From Delegate";

      d(text);
    }
  }
}