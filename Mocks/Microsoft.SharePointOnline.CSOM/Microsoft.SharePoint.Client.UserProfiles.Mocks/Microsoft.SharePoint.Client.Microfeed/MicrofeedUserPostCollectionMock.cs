
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedUserPostCollectionMock : MicrofeedUserPostCollection
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

