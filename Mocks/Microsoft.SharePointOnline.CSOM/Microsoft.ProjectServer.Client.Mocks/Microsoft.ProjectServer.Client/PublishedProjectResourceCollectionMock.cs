
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PublishedProjectResourceCollectionMock : PublishedProjectResourceCollection
    {


        public override Microsoft.ProjectServer.Client.PublishedProjectResource GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PublishedProjectResource GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedProjectResource GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PublishedProjectResource GetByGuidEx { get; set;}

    }
}

