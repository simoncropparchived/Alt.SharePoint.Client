
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostReferenceMock
    {


        public override Microsoft.SharePoint.Client.Social.SocialThread Digest => DigestEx;
        public Microsoft.SharePoint.Client.Social.SocialThread DigestEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPost Post => PostEx;
        public Microsoft.SharePoint.Client.Social.SocialPost PostEx { get; set; }

        public override System.String ThreadId => ThreadIdEx;
        public System.String ThreadIdEx { get; set; }

        public override System.Int32 ThreadOwnerIndex => ThreadOwnerIndexEx;
        public System.Int32 ThreadOwnerIndexEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

