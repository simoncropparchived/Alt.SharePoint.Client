
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialRestFeedMock : SocialRestFeed
    {


        public override Microsoft.SharePoint.Client.Social.SocialFeed SocialFeed => SocialFeedEx;
        public Microsoft.SharePoint.Client.Social.SocialFeed SocialFeedEx { get; set; }

    }
}

