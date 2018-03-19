
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AttachmentCreationInformationMock : AttachmentCreationInformation
    {


        public override System.IO.Stream ContentStream => ContentStreamEx;
        public System.IO.Stream ContentStreamEx { get; set; }

        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

