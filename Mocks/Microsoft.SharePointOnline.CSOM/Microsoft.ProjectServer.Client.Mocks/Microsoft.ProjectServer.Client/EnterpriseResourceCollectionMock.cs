
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCollectionMock : EnterpriseResourceCollection
    {


        public override Microsoft.ProjectServer.Client.EnterpriseResource GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResource GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.EnterpriseResource GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResource GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.EnterpriseResource GetByUser(Microsoft.SharePoint.Client.User @user)
        {
            return GetByUserEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResource GetByUserEx { get; set;}

        public override Microsoft.ProjectServer.Client.EnterpriseResource Add(Microsoft.ProjectServer.Client.EnterpriseResourceCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResource AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.EnterpriseResource @resource)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

    }
}

