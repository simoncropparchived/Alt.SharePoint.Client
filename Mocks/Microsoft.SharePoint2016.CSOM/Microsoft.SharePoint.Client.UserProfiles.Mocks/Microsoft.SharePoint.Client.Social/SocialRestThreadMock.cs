
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialRestThreadMock : SocialRestThread
    {


        public override System.String ID => IDEx;
        public System.String IDEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialThread SocialThread => SocialThreadEx;
        public Microsoft.SharePoint.Client.Social.SocialThread SocialThreadEx { get; set; }

    }
}

