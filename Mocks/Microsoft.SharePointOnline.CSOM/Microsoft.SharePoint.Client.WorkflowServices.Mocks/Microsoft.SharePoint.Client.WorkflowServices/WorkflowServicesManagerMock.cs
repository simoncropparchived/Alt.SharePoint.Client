
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowServicesManagerMock : WorkflowServicesManager
    {


        public override System.String AppId => AppIdEx;
        public System.String AppIdEx { get; set; }

        public override System.Boolean IsConnected => IsConnectedEx;
        public System.Boolean IsConnectedEx { get; set; }

        public override System.String ScopePath => ScopePathEx;
        public System.String ScopePathEx { get; set; }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowServiceHealthStatus ServiceHealthStatus => ServiceHealthStatusEx;
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowServiceHealthStatus ServiceHealthStatusEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsIntegratedApp()
        {
            return IsIntegratedAppEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsIntegratedAppEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowDeploymentService GetWorkflowDeploymentService()
        {
            return GetWorkflowDeploymentServiceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowDeploymentService GetWorkflowDeploymentServiceEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceService GetWorkflowInstanceService()
        {
            return GetWorkflowInstanceServiceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceService GetWorkflowInstanceServiceEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.InteropService GetWorkflowInteropService()
        {
            return GetWorkflowInteropServiceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.InteropService GetWorkflowInteropServiceEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionService GetWorkflowSubscriptionService()
        {
            return GetWorkflowSubscriptionServiceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscriptionService GetWorkflowSubscriptionServiceEx { get; set;}

    }
}

