
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class InteropServiceMock : InteropService
    {


        public override void EnableEvents(System.Guid @listId, System.Guid @itemGuid)
        {
        }

        public override void DisableEvents(System.Guid @listId, System.Guid @itemGuid)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflow(System.String @associationName, System.Guid @correlationId, System.Guid @listId, System.Guid @itemGuid, System.Collections.Generic.IDictionary<System.String, System.Object> @workflowParameters)
        {
            return StartWorkflowEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> StartWorkflowEx { get; set;}

        public override void CancelWorkflow(System.Guid @instanceId)
        {
        }

    }
}

