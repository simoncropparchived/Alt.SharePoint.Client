
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class ExternalUserCollectionMock : ExternalUserCollection
    {


        public override Microsoft.Online.SharePoint.TenantManagement.ExternalUser GetById(System.String @uniqueId)
        {
            return GetByIdEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.ExternalUser GetByIdEx { get; set;}

    }
}

