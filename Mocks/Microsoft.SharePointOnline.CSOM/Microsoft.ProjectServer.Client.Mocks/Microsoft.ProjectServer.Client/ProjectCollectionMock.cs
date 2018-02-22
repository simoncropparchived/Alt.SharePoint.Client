
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectCollectionMock : ProjectCollection
    {


        public override Microsoft.ProjectServer.Client.PublishedProject GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PublishedProject GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedProject GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PublishedProject GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedProject Add(Microsoft.ProjectServer.Client.ProjectCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.PublishedProject AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.PublishedProject @project)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Validate()
        {
        }

        public override Microsoft.ProjectServer.Client.QueueJob Update()
        {
            return UpdateEx;
        }
        public Microsoft.ProjectServer.Client.QueueJob UpdateEx { get; set;}

    }
}

