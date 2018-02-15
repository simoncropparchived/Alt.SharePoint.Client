
namespace Microsoft.Office.Client.Education
{
    public class CommunityMock : Community
    {


        public override Microsoft.Office.Client.Education.Memberships Memberships => MembershipsEx;
        public Microsoft.Office.Client.Education.Memberships MembershipsEx { get; set; }

        public override System.String SiteUrl => SiteUrlEx;
        public System.String SiteUrlEx { get; set; }

        public override Microsoft.Office.Client.Education.CommunityStatus Status => StatusEx;
        public Microsoft.Office.Client.Education.CommunityStatus StatusEx { get; set; }

        public override System.String Tags => TagsEx;
        public System.String TagsEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String WebPath => WebPathEx;
        public System.String WebPathEx { get; set; }

    }
}

