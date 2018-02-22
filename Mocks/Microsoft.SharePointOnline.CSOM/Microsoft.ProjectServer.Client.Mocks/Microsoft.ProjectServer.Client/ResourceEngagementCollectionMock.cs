
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ResourceEngagementCollectionMock : ResourceEngagementCollection
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.Engagement @engagement)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.ProjectServer.Client.ResourceEngagement GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.ResourceEngagement GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.ResourceEngagement GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.ResourceEngagement GetByGuidEx { get; set;}

    }
}

