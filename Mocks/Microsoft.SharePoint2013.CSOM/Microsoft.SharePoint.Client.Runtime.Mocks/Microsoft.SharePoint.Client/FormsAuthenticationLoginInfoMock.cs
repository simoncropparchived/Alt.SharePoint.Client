
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FormsAuthenticationLoginInfoMock : FormsAuthenticationLoginInfo
    {


        public override System.String LoginName => LoginNameEx;
        public System.String LoginNameEx { get; set; }

        public override System.String Password => PasswordEx;
        public System.String PasswordEx { get; set; }

        public override System.Uri AuthenticationServiceUrl => AuthenticationServiceUrlEx;
        public System.Uri AuthenticationServiceUrlEx { get; set; }

    }
}

