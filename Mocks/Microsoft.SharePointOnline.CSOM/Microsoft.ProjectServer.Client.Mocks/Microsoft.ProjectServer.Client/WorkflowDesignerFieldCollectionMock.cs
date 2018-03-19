
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class WorkflowDesignerFieldCollectionMock : WorkflowDesignerFieldCollection
    {


        public override Microsoft.ProjectServer.Client.WorkflowDesignerField GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.WorkflowDesignerField GetByIdEx { get; set;}

    }
}

