using System.IO;
using System.Xml.Serialization;

namespace Torment.utils
{
    /// <summary>
    /// An XML serializer for saving and loading game assets
    /// </summary>
    public class Serializer
    {
        public static void Serialize(string details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));
            using (TextWriter writer = new StreamWriter("Content/save.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
    }
}