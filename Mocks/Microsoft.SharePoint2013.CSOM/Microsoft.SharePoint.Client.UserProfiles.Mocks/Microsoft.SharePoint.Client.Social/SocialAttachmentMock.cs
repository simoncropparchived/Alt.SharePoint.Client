
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialAttachmentMock : SocialAttachment
    {


        public override Microsoft.SharePoint.Client.Social.SocialAttachmentKind AttachmentKind => AttachmentKindEx;
        public Microsoft.SharePoint.Client.Social.SocialAttachmentKind AttachmentKindEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialAttachmentAction ClickAction => ClickActionEx;
        public Microsoft.SharePoint.Client.Social.SocialAttachmentAction ClickActionEx { get; set; }

        public override System.String ContentUri => ContentUriEx;
        public System.String ContentUriEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.UInt32 Height => HeightEx;
        public System.UInt32 HeightEx { get; set; }

        public override System.UInt32 Length => LengthEx;
        public System.UInt32 LengthEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String PreviewUri => PreviewUriEx;
        public System.String PreviewUriEx { get; set; }

        public override System.String Uri => UriEx;
        public System.String UriEx { get; set; }

        public override System.UInt32 Width => WidthEx;
        public System.UInt32 WidthEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

