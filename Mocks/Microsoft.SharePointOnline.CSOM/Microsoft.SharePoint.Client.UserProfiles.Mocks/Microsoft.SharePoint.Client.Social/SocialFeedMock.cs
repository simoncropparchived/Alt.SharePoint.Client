
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFeedMock
    {


        public override Microsoft.SharePoint.Client.Social.SocialFeedAttributes Attributes => AttributesEx;
        public Microsoft.SharePoint.Client.Social.SocialFeedAttributes AttributesEx { get; set; }

        public override System.DateTime NewestProcessed => NewestProcessedEx;
        public System.DateTime NewestProcessedEx { get; set; }

        public override System.DateTime OldestProcessed => OldestProcessedEx;
        public System.DateTime OldestProcessedEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialThread[] Threads => ThreadsEx;
        public Microsoft.SharePoint.Client.Social.SocialThread[] ThreadsEx { get; set; }

        public override System.Int32 UnreadMentionCount => UnreadMentionCountEx;
        public System.Int32 UnreadMentionCountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

