
namespace Microsoft.SharePoint.Client
{
    public class ExternalAppPrincipalCreationParametersMock : ExternalAppPrincipalCreationParameters
    {


        public override System.String AppIdentifier => AppIdentifierEx;
        public System.String AppIdentifierEx { get; set; }

        public override System.Collections.Generic.IList<System.String> ApplicationEndpointAuthorities => ApplicationEndpointAuthoritiesEx;
        public System.Collections.Generic.IList<System.String> ApplicationEndpointAuthoritiesEx { get; set; }

        public override Microsoft.SharePoint.Client.AppPrincipalCredential Credential => CredentialEx;
        public Microsoft.SharePoint.Client.AppPrincipalCredential CredentialEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.Collections.Generic.IList<System.String> RedirectAddresses => RedirectAddressesEx;
        public System.Collections.Generic.IList<System.String> RedirectAddressesEx { get; set; }

        public override System.Boolean TrustedForDelegation => TrustedForDelegationEx;
        public System.Boolean TrustedForDelegationEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

