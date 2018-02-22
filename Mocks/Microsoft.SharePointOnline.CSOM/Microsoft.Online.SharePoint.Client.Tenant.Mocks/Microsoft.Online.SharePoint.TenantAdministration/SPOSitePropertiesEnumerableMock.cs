
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPOSitePropertiesEnumerableMock : SPOSitePropertiesEnumerable
    {


        public override System.Int32 NextStartIndex => NextStartIndexEx;
        public System.Int32 NextStartIndexEx { get; set; }

        public override System.String NextStartIndexFromSharePoint => NextStartIndexFromSharePointEx;
        public System.String NextStartIndexFromSharePointEx { get; set; }

    }
}

