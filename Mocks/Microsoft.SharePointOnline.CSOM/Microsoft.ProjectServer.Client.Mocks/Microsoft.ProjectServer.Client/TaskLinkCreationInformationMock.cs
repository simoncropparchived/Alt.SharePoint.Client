
namespace Microsoft.ProjectServer.Client
{
    public class TaskLinkCreationInformationMock : TaskLinkCreationInformation
    {


        public override Microsoft.ProjectServer.Client.DependencyType DependencyType => DependencyTypeEx;
        public Microsoft.ProjectServer.Client.DependencyType DependencyTypeEx { get; set; }

        public override System.Guid EndId => EndIdEx;
        public System.Guid EndIdEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Guid StartId => StartIdEx;
        public System.Guid StartIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

