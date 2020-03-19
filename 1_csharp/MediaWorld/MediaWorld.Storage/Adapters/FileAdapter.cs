using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage.Adapters
{
  public class FileAdapter
  {
    private static string _path = @"../medialib.xml";
    //public static string file = "medialib.xml";


    public static IEnumerable<AMedia> Read(string path) //string path
    {
      var p = path ?? _path;
      //var p = path is null ? _path : path;
      //var FullPath = Path.GetFullPath(p);

      var reader = new StreamReader(p);
      var xml = new XmlSerializer(typeof(List<AMedia>), new []{typeof(Song), typeof(Book)});
      var la = xml.Deserialize(reader) as List<AMedia>;  
      return la; 
    }

    public static bool Write(List<AMedia> lib)
    {
      using(var writer = new StreamWriter(_path))
      {
        var xml = new XmlSerializer(typeof(List<AMedia>), new []{typeof(Song), typeof(Book)});
        xml.Serialize(writer, lib);
        return true;
      }       
    }
  }
}