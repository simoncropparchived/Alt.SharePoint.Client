
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Workflow
{
    public class WorkflowTemplateCollectionMock : WorkflowTemplateCollection
    {


        public override Microsoft.SharePoint.Client.Workflow.WorkflowTemplate GetById(System.Guid @templateId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Workflow.WorkflowTemplate GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Workflow.WorkflowTemplate GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Workflow.WorkflowTemplate GetByNameEx { get; set;}

    }
}

