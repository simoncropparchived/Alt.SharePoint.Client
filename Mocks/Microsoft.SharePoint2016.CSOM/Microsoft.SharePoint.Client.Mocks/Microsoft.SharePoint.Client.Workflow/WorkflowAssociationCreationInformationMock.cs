
namespace Microsoft.SharePoint.Client.Workflow
{
    public class WorkflowAssociationCreationInformationMock : WorkflowAssociationCreationInformation
    {


        public override System.String ContentTypeAssociationHistoryListName => ContentTypeAssociationHistoryListNameEx;
        public System.String ContentTypeAssociationHistoryListNameEx { get; set; }

        public override System.String ContentTypeAssociationTaskListName => ContentTypeAssociationTaskListNameEx;
        public System.String ContentTypeAssociationTaskListNameEx { get; set; }

        public override Microsoft.SharePoint.Client.List HistoryList => HistoryListEx;
        public Microsoft.SharePoint.Client.List HistoryListEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.List TaskList => TaskListEx;
        public Microsoft.SharePoint.Client.List TaskListEx { get; set; }

        public override Microsoft.SharePoint.Client.Workflow.WorkflowTemplate Template => TemplateEx;
        public Microsoft.SharePoint.Client.Workflow.WorkflowTemplate TemplateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

