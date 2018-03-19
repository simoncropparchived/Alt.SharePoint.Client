
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseProjectTypeCollectionMock : EnterpriseProjectTypeCollection
    {


        public override Microsoft.ProjectServer.Client.EnterpriseProjectType GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseProjectType GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.EnterpriseProjectType GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseProjectType GetByGuidEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.ProjectServer.Client.EnterpriseProjectType Add(Microsoft.ProjectServer.Client.EnterpriseProjectTypeCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseProjectType AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.EnterpriseProjectType @ept)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

