
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialAttachmentActionMock
    {


        public override Microsoft.SharePoint.Client.Social.SocialAttachmentActionKind ActionKind => ActionKindEx;
        public Microsoft.SharePoint.Client.Social.SocialAttachmentActionKind ActionKindEx { get; set; }

        public override System.String ActionUri => ActionUriEx;
        public System.String ActionUriEx { get; set; }

        public override System.UInt32 Height => HeightEx;
        public System.UInt32 HeightEx { get; set; }

        public override System.UInt32 Width => WidthEx;
        public System.UInt32 WidthEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

