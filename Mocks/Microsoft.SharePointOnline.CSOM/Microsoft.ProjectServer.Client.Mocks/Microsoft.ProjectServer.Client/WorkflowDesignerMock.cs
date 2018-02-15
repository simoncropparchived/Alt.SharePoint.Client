
namespace Microsoft.ProjectServer.Client
{
    public class WorkflowDesignerMock : WorkflowDesigner
    {


        public override Microsoft.ProjectServer.Client.WorkflowDesignerFieldCollection Fields => FieldsEx;
        public Microsoft.ProjectServer.Client.WorkflowDesignerFieldCollection FieldsEx { get; set; }

    }
}

