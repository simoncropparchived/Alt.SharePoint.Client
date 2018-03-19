
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantSiteScriptActionResultMock : TenantSiteScriptActionResult
    {


        public override Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScriptActionOutcome Outcome => OutcomeEx;
        public Microsoft.Online.SharePoint.TenantAdministration.TenantSiteScriptActionOutcome OutcomeEx { get; set; }

        public override System.String OutcomeText => OutcomeTextEx;
        public System.String OutcomeTextEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

    }
}

