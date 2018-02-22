
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FormDigestInfoMock : FormDigestInfo
    {


        public override System.String DigestValue => DigestValueEx;
        public System.String DigestValueEx { get; set; }

        public override System.DateTime Expiration => ExpirationEx;
        public System.DateTime ExpirationEx { get; set; }

    }
}

