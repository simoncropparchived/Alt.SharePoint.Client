
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class SharePointOnlineCredentialsMock : SharePointOnlineCredentials
    {


        public override System.String UserName => UserNameEx;
        public System.String UserNameEx { get; set; }

        public override System.Net.NetworkCredential GetCredential(System.Uri @uri, System.String @authType)
        {
            return GetCredentialEx;
        }
        public System.Net.NetworkCredential GetCredentialEx { get; set;}

        public override System.String GetAuthenticationCookie(System.Uri @url)
        {
            return GetAuthenticationCookieUriEx;
        }
        public System.String GetAuthenticationCookieUriEx { get; set;}

        public override System.String GetAuthenticationCookie(System.Uri @url, System.Boolean @alwaysThrowOnFailure)
        {
            return GetAuthenticationCookieUriBooleanEx;
        }
        public System.String GetAuthenticationCookieUriBooleanEx { get; set;}

    }
}

