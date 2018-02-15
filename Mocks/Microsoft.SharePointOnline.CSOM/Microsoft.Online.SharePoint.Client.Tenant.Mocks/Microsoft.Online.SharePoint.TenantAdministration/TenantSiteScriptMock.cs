
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantSiteScriptMock : TenantSiteScript
    {


        public override System.String Content => ContentEx;
        public System.String ContentEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Int32 Version => VersionEx;
        public System.Int32 VersionEx { get; set; }

    }
}

