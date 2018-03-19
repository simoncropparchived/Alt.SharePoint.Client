
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalPermissionRequestCollectionMock : SPOWebAppServicePrincipalPermissionRequestCollection
    {


        public override Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionRequest GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.Internal.SPOWebAppServicePrincipalPermissionRequest GetByIdEx { get; set;}

    }
}

