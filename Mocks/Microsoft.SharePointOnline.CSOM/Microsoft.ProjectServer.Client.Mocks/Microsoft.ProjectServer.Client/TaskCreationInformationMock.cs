
namespace Microsoft.ProjectServer.Client
{
    public class TaskCreationInformationMock : TaskCreationInformation
    {


        public override System.Guid AddAfterId => AddAfterIdEx;
        public System.Guid AddAfterIdEx { get; set; }

        public override System.String Duration => DurationEx;
        public System.String DurationEx { get; set; }

        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsManual => IsManualEx;
        public System.Boolean IsManualEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.Guid ParentId => ParentIdEx;
        public System.Guid ParentIdEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override Microsoft.SharePoint.Client.User StatusManager => StatusManagerEx;
        public Microsoft.SharePoint.Client.User StatusManagerEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

