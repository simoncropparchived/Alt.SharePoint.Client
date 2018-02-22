
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowInstanceServiceMock : WorkflowInstanceService
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflow(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @subscription, System.Collections.Generic.IDictionary<System.String,System.Object> @payload)
        {
            return StartWorkflowEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflowEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflowOnListItem(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @subscription, System.Int32 @itemId, System.Collections.Generic.IDictionary<System.String,System.Object> @payload)
        {
            return StartWorkflowOnListItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflowOnListItemEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance GetInstance(System.Guid @instanceId)
        {
            return GetInstanceEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance GetInstanceEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection Enumerate(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @parentSubscription)
        {
            return EnumerateEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateWithOffset(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @parentSubscription, System.Int32 @offset)
        {
            return EnumerateWithOffsetEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateWithOffsetEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForListItem(System.Guid @listId, System.Int32 @itemId)
        {
            return EnumerateInstancesForListItemEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForListItemEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForListItemWithOffset(System.Guid @listId, System.Int32 @itemId, System.Int32 @offset)
        {
            return EnumerateInstancesForListItemWithOffsetEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForListItemWithOffsetEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForSite()
        {
            return EnumerateInstancesForSiteEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForSiteEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForSiteWithOffset(System.Int32 @offset)
        {
            return EnumerateInstancesForSiteWithOffsetEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstanceCollection EnumerateInstancesForSiteWithOffsetEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> CountInstances(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @parentSubscription)
        {
            return CountInstancesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> CountInstancesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> CountInstancesWithStatus(Microsoft.SharePoint.Client.WorkflowServices.WorkflowSubscription @parentSubscription, Microsoft.SharePoint.Client.WorkflowServices.WorkflowStatus @status)
        {
            return CountInstancesWithStatusEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> CountInstancesWithStatusEx { get; set;}

        public override void CancelWorkflow(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance)
        {
        }

        public override void TerminateWorkflow(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance)
        {
        }

        public override void SuspendWorkflow(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance)
        {
        }

        public override void ResumeWorkflow(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance)
        {
        }

        public override void PublishCustomEvent(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance, System.String @eventName, System.String @payload)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDebugInfo(Microsoft.SharePoint.Client.WorkflowServices.WorkflowInstance @instance)
        {
            return GetDebugInfoEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDebugInfoEx { get; set;}

    }
}

