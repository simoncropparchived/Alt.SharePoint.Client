
namespace Microsoft.SharePoint.Client
{
    public class TenantSettingsMock : TenantSettings
    {


        public override System.String CorporateCatalogUrl => CorporateCatalogUrlEx;
        public System.String CorporateCatalogUrlEx { get; set; }

    }
}

