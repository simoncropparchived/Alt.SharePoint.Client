
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPODeletedSitePropertiesEnumerableMock : SPODeletedSitePropertiesEnumerable
    {


        public override System.Int32 NextStartIndex => NextStartIndexEx;
        public System.Int32 NextStartIndexEx { get; set; }

    }
}

