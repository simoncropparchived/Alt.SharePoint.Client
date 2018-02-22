
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.ContentPush
{
    public class CertificateServiceMock : CertificateService
    {


        public override System.Collections.Generic.IEnumerable<System.Byte[]> ValidContentEncryptionCertificates()
        {
            return ValidContentEncryptionCertificatesEx;
        }
        public System.Collections.Generic.IEnumerable<System.Byte[]> ValidContentEncryptionCertificatesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String,System.Object>> CertificateSettings()
        {
            return CertificateSettingsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String,System.Object>> CertificateSettingsEx { get; set;}

    }
}

