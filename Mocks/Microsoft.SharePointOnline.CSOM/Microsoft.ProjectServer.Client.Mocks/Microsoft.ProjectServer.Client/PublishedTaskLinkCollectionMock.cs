
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PublishedTaskLinkCollectionMock : PublishedTaskLinkCollection
    {


        public override Microsoft.ProjectServer.Client.PublishedTaskLink GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PublishedTaskLink GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedTaskLink GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PublishedTaskLink GetByGuidEx { get; set;}

    }
}

