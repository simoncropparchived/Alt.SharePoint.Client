
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DeletedPublishedAssignmentMock : DeletedPublishedAssignment
    {


        public override System.DateTime DeletedDate => DeletedDateEx;
        public System.DateTime DeletedDateEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Guid ProjectId => ProjectIdEx;
        public System.Guid ProjectIdEx { get; set; }

    }
}

