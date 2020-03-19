using System.Xml.Serialization;

namespace MediaWorld.Domain.Abstracts
{
  public abstract class AMedia
  {
    // public string Title { get; set; } = "C#";
    [XmlElement]
    public string Title { get; set; }

    protected AMedia()
    {
      Title = "Revature";
    }
  }
}