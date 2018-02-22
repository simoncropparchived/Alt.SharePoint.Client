
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectEngagementCollectionMock : ProjectEngagementCollection
    {


        public override Microsoft.ProjectServer.Client.ProjectEngagement Add(Microsoft.ProjectServer.Client.ProjectEngagementCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.ProjectEngagement AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.Engagement @engagement)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.ProjectServer.Client.ProjectEngagement GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.ProjectEngagement GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.ProjectEngagement GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.ProjectEngagement GetByGuidEx { get; set;}

    }
}

