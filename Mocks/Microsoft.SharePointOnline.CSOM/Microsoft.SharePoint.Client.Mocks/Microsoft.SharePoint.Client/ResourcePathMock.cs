
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ResourcePathMock : ResourcePath
    {


        public override System.String DecodedUrl => DecodedUrlEx;
        public System.String DecodedUrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

