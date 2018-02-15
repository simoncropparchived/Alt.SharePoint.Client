
namespace Microsoft.SharePoint.Client
{
    public class AppPrincipalMock
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> EndpointAuthorities => EndpointAuthoritiesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> EndpointAuthoritiesEx { get; set; }

        public override System.String NameIdentifier => NameIdentifierEx;
        public System.String NameIdentifierEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> RedirectAddresses => RedirectAddressesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> RedirectAddressesEx { get; set; }

    }
}

