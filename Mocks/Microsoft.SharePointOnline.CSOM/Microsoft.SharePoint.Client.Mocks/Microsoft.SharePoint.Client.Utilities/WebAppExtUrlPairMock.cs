
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Utilities
{
    public class WebAppExtUrlPairMock : WebAppExtUrlPair
    {


        public override System.String Ext => ExtEx;
        public System.String ExtEx { get; set; }

        public override System.String WacUrl => WacUrlEx;
        public System.String WacUrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

