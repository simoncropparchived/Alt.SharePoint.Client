
namespace Microsoft.ProjectServer.Client
{
    public class AssignmentCreationInformationMock : AssignmentCreationInformation
    {


        public override System.DateTime Finish => FinishEx;
        public System.DateTime FinishEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.Guid ResourceId => ResourceIdEx;
        public System.Guid ResourceIdEx { get; set; }

        public override System.DateTime Start => StartEx;
        public System.DateTime StartEx { get; set; }

        public override System.Guid TaskId => TaskIdEx;
        public System.Guid TaskIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

