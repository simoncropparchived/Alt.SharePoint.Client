
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class DocumentLibraryInformationMock : DocumentLibraryInformation
    {


        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String ModifiedFriendlyDisplay => ModifiedFriendlyDisplayEx;
        public System.String ModifiedFriendlyDisplayEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

