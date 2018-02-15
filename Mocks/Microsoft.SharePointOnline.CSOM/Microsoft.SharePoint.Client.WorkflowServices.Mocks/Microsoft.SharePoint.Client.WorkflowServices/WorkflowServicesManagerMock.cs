
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowServicesManagerMock
    {


        public override System.String AppId => AppIdEx;
        public System.String AppIdEx { get; set; }

        public override System.Boolean IsConnected => IsConnectedEx;
        public System.Boolean IsConnectedEx { get; set; }

        public override System.String ScopePath => ScopePathEx;
        public System.String ScopePathEx { get; set; }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowServiceHealthStatus ServiceHealthStatus => ServiceHealthStatusEx;
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowServiceHealthStatus ServiceHealthStatusEx { get; set; }

    }
}

