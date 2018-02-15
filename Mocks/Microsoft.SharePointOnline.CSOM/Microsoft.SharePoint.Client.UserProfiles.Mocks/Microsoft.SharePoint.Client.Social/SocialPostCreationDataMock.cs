
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostCreationDataMock : SocialPostCreationData
    {


        public override Microsoft.SharePoint.Client.Social.SocialAttachment Attachment => AttachmentEx;
        public Microsoft.SharePoint.Client.Social.SocialAttachment AttachmentEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialDataItem[] ContentItems => ContentItemsEx;
        public Microsoft.SharePoint.Client.Social.SocialDataItem[] ContentItemsEx { get; set; }

        public override System.String ContentText => ContentTextEx;
        public System.String ContentTextEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostDefinitionData DefinitionData => DefinitionDataEx;
        public Microsoft.SharePoint.Client.Social.SocialPostDefinitionData DefinitionDataEx { get; set; }

        public override System.String[] SecurityUris => SecurityUrisEx;
        public System.String[] SecurityUrisEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialLink Source => SourceEx;
        public Microsoft.SharePoint.Client.Social.SocialLink SourceEx { get; set; }

        public override System.Boolean UpdateStatusText => UpdateStatusTextEx;
        public System.Boolean UpdateStatusTextEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

