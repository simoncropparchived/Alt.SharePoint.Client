
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DraftProjectResourceCollectionMock : DraftProjectResourceCollection
    {


        public override Microsoft.ProjectServer.Client.DraftProjectResource GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.DraftProjectResource GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftProjectResource GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.DraftProjectResource GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftProjectResource Add(Microsoft.ProjectServer.Client.ProjectResourceCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.DraftProjectResource AddEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftProjectResource AddEnterpriseResource(Microsoft.ProjectServer.Client.EnterpriseResource @resource)
        {
            return AddEnterpriseResourceEx;
        }
        public Microsoft.ProjectServer.Client.DraftProjectResource AddEnterpriseResourceEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.DraftProjectResource @resource)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

