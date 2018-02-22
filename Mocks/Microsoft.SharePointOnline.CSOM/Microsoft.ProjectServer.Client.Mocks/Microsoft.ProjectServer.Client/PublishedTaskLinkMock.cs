
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PublishedTaskLinkMock : PublishedTaskLink
    {


        public override Microsoft.ProjectServer.Client.DependencyType DependencyType => DependencyTypeEx;
        public Microsoft.ProjectServer.Client.DependencyType DependencyTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedTask End => EndEx;
        public Microsoft.ProjectServer.Client.PublishedTask EndEx { get; set; }

        public override Microsoft.ProjectServer.Client.PublishedTask Start => StartEx;
        public Microsoft.ProjectServer.Client.PublishedTask StartEx { get; set; }

    }
}

