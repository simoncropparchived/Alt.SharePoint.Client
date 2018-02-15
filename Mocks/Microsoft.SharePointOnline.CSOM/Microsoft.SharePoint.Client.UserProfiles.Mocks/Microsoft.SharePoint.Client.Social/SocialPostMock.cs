
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostMock
    {


        public override Microsoft.SharePoint.Client.Social.SocialAttachment Attachment => AttachmentEx;
        public Microsoft.SharePoint.Client.Social.SocialAttachment AttachmentEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostAttributes Attributes => AttributesEx;
        public Microsoft.SharePoint.Client.Social.SocialPostAttributes AttributesEx { get; set; }

        public override System.Int32 AuthorIndex => AuthorIndexEx;
        public System.Int32 AuthorIndexEx { get; set; }

        public override System.DateTime CreatedTime => CreatedTimeEx;
        public System.DateTime CreatedTimeEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostActorInfo LikerInfo => LikerInfoEx;
        public Microsoft.SharePoint.Client.Social.SocialPostActorInfo LikerInfoEx { get; set; }

        public override System.DateTime ModifiedTime => ModifiedTimeEx;
        public System.DateTime ModifiedTimeEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialDataOverlay[] Overlays => OverlaysEx;
        public Microsoft.SharePoint.Client.Social.SocialDataOverlay[] OverlaysEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostType PostType => PostTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialPostType PostTypeEx { get; set; }

        public override System.String PreferredImageUri => PreferredImageUriEx;
        public System.String PreferredImageUriEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialLink Source => SourceEx;
        public Microsoft.SharePoint.Client.Social.SocialLink SourceEx { get; set; }

        public override System.String Text => TextEx;
        public System.String TextEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

