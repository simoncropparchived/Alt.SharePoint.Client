
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.SiteHealth
{
    public class SiteHealthSummaryMock : SiteHealthSummary
    {


        public override System.Int32 FailedErrorCount => FailedErrorCountEx;
        public System.Int32 FailedErrorCountEx { get; set; }

        public override System.Int32 FailedWarningCount => FailedWarningCountEx;
        public System.Int32 FailedWarningCountEx { get; set; }

        public override System.Int32 PassedCount => PassedCountEx;
        public System.Int32 PassedCountEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.SiteHealth.SiteHealthResult> Results => ResultsEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.SiteHealth.SiteHealthResult> ResultsEx { get; set; }

    }
}

