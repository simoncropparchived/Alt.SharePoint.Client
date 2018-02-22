
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Workflow
{
    public class WorkflowAssociationCollectionMock : WorkflowAssociationCollection
    {


        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociation GetById(System.Guid @associationId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociation GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociation Add(Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociation AddEx { get; set;}

        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociation GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociation GetByNameEx { get; set;}

    }
}

