
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DraftTaskLinkMock : DraftTaskLink
    {


        public override Microsoft.ProjectServer.Client.DependencyType DependencyType => DependencyTypeEx;
        public Microsoft.ProjectServer.Client.DependencyType DependencyTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftTask End => EndEx;
        public Microsoft.ProjectServer.Client.DraftTask EndEx { get; set; }

        public override Microsoft.ProjectServer.Client.DraftTask Start => StartEx;
        public Microsoft.ProjectServer.Client.DraftTask StartEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

