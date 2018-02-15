
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedManagerMock
    {


        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity CurrentUser => CurrentUserEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity CurrentUserEx { get; set; }

        public override System.Boolean IsFeedActivityPublic => IsFeedActivityPublicEx;
        public System.Boolean IsFeedActivityPublicEx { get; set; }

        public override System.String StaticThreadLink => StaticThreadLinkEx;
        public System.String StaticThreadLinkEx { get; set; }

    }
}

