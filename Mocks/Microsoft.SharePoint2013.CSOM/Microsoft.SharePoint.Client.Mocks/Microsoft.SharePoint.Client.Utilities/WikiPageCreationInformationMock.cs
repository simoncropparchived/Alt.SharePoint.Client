
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Utilities
{
    public class WikiPageCreationInformationMock : WikiPageCreationInformation
    {


        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String WikiHtmlContent => WikiHtmlContentEx;
        public System.String WikiHtmlContentEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

