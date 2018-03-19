
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

    }
}

