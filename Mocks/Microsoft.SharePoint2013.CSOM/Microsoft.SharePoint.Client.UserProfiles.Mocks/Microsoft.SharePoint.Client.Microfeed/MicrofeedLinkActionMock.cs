
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedLinkActionMock : MicrofeedLinkAction
    {


        public override System.String ActionUri => ActionUriEx;
        public System.String ActionUriEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkActionKind Kind => KindEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkActionKind KindEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

