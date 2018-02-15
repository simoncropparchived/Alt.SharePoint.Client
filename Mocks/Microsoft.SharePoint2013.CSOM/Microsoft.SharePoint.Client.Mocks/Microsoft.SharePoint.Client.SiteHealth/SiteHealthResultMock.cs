
namespace Microsoft.SharePoint.Client.SiteHealth
{
    public class SiteHealthResultMock
    {


        public override System.String MessageAsText => MessageAsTextEx;
        public System.String MessageAsTextEx { get; set; }

        public override System.String RuleHelpLink => RuleHelpLinkEx;
        public System.String RuleHelpLinkEx { get; set; }

        public override System.Guid RuleId => RuleIdEx;
        public System.Guid RuleIdEx { get; set; }

        public override System.Boolean RuleIsRepairable => RuleIsRepairableEx;
        public System.Boolean RuleIsRepairableEx { get; set; }

        public override System.String RuleName => RuleNameEx;
        public System.String RuleNameEx { get; set; }

        public override Microsoft.SharePoint.Client.SiteHealth.SiteHealthStatusType Status => StatusEx;
        public Microsoft.SharePoint.Client.SiteHealth.SiteHealthStatusType StatusEx { get; set; }

        public override System.DateTime TimeStamp => TimeStampEx;
        public System.DateTime TimeStampEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

