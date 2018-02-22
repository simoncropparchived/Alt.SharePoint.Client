
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowInstanceMock : WorkflowInstance
    {


        public override System.String FaultInfo => FaultInfoEx;
        public System.String FaultInfoEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.DateTime InstanceCreated => InstanceCreatedEx;
        public System.DateTime InstanceCreatedEx { get; set; }

        public override System.DateTime LastUpdated => LastUpdatedEx;
        public System.DateTime LastUpdatedEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> PropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowStatus StatusEx { get; set; }

        public override System.String UserStatus => UserStatusEx;
        public System.String UserStatusEx { get; set; }

        public override System.Guid WorkflowSubscriptionId => WorkflowSubscriptionIdEx;
        public System.Guid WorkflowSubscriptionIdEx { get; set; }

    }
}

