
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class MediaServiceUpdateParametersMock : MediaServiceUpdateParameters
    {


        public override System.Int32 ContentVersion => ContentVersionEx;
        public System.Int32 ContentVersionEx { get; set; }

        public override System.String MediaServiceAutoTags => MediaServiceAutoTagsEx;
        public System.String MediaServiceAutoTagsEx { get; set; }

        public override System.String MediaServiceDateTaken => MediaServiceDateTakenEx;
        public System.String MediaServiceDateTakenEx { get; set; }

        public override System.String MediaServiceFastMetadata => MediaServiceFastMetadataEx;
        public System.String MediaServiceFastMetadataEx { get; set; }

        public override System.String MediaServiceLocation => MediaServiceLocationEx;
        public System.String MediaServiceLocationEx { get; set; }

        public override System.String MediaServiceMetadata => MediaServiceMetadataEx;
        public System.String MediaServiceMetadataEx { get; set; }

        public override System.String MediaServiceOCR => MediaServiceOCREx;
        public System.String MediaServiceOCREx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

