
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPSyncNotificationEndpointInfoMock : SPSyncNotificationEndpointInfo
    {


        public override System.Boolean IsNotifySuccess => IsNotifySuccessEx;
        public System.Boolean IsNotifySuccessEx { get; set; }

        public override System.String MasterCorrelationId => MasterCorrelationIdEx;
        public System.String MasterCorrelationIdEx { get; set; }

        public override System.String ServerBuild => ServerBuildEx;
        public System.String ServerBuildEx { get; set; }

        public override System.String ServerName => ServerNameEx;
        public System.String ServerNameEx { get; set; }

        public override System.String WorkloadCorrelationId => WorkloadCorrelationIdEx;
        public System.String WorkloadCorrelationIdEx { get; set; }

    }
}

