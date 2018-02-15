
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class GetExternalUsersResultsMock
    {


        public override Microsoft.Online.SharePoint.TenantManagement.ExternalUserCollection ExternalUserCollection => ExternalUserCollectionEx;
        public Microsoft.Online.SharePoint.TenantManagement.ExternalUserCollection ExternalUserCollectionEx { get; set; }

        public override System.Int32 TotalUserCount => TotalUserCountEx;
        public System.Int32 TotalUserCountEx { get; set; }

        public override System.Int32 UserCollectionPosition => UserCollectionPositionEx;
        public System.Int32 UserCollectionPositionEx { get; set; }

    }
}

