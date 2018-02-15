
namespace Microsoft.SharePoint.Client.Search.ContentPush
{
    public class PushTenantServiceInfoMock
    {


        public override System.String AuthenticationRealm => AuthenticationRealmEx;
        public System.String AuthenticationRealmEx { get; set; }

        public override System.String EndpointAddress => EndpointAddressEx;
        public System.String EndpointAddressEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.Object> ServiceProperties => ServicePropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.Object> ServicePropertiesEx { get; set; }

        public override System.String TenantId => TenantIdEx;
        public System.String TenantIdEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Byte[]> ValidContentEncryptionCertificates => ValidContentEncryptionCertificatesEx;
        public System.Collections.Generic.IEnumerable`1<System.Byte[]> ValidContentEncryptionCertificatesEx { get; set; }

        public override System.DateTime ValidUntil => ValidUntilEx;
        public System.DateTime ValidUntilEx { get; set; }

    }
}

