using System.Xml.Serialization;

namespace UnlockAllWondersAndLandmarks.OptionsFramework
{
    public interface IModOptions
    {
        [XmlIgnore]
        string FileName
        {
            get;
        }
    }
}