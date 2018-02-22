
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalPermissionGrantCollectionMock : SPOWebAppServicePrincipalPermissionGrantCollection
    {


        public override Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrant GetByObjectId(System.String @objectId)
        {
            return GetByObjectIdEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionGrant GetByObjectIdEx { get; set;}

    }
}

