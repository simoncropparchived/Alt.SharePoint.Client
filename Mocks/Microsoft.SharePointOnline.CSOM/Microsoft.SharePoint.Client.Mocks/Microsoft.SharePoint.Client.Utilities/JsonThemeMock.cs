
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Utilities
{
    public class JsonThemeMock : JsonTheme
    {


        public override System.String name => nameEx;
        public System.String nameEx { get; set; }

        public override System.String themeJson => themeJsonEx;
        public System.String themeJsonEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

