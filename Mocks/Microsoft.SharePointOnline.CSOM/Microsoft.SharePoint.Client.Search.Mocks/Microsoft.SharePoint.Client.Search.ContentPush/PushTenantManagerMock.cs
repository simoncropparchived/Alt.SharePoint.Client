
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.ContentPush
{
    public class PushTenantManagerMock : PushTenantManager
    {


        public override void PreparePushTenant()
        {
        }

        public override Microsoft.SharePoint.Client.Search.ContentPush.PushTenantServiceInfo GetPushServiceInfo()
        {
            return GetPushServiceInfoEx;
        }
        public Microsoft.SharePoint.Client.Search.ContentPush.PushTenantServiceInfo GetPushServiceInfoEx { get; set;}

        public override Microsoft.SharePoint.Client.Search.ContentPush.PushTenantServiceInfo GetTenantInfo()
        {
            return GetTenantInfoEx;
        }
        public Microsoft.SharePoint.Client.Search.ContentPush.PushTenantServiceInfo GetTenantInfoEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int64> DeleteAllCloudHybridSearchContent()
        {
            return DeleteAllCloudHybridSearchContentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int64> DeleteAllCloudHybridSearchContentEx { get; set;}

    }
}

