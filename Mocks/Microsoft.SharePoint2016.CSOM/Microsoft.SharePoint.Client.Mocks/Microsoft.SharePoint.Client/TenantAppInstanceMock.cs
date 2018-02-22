
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class TenantAppInstanceMock : TenantAppInstance
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

