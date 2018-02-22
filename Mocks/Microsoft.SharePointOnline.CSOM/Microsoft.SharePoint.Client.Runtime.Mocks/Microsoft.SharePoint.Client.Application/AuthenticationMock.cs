
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Application
{
    public class AuthenticationMock : Authentication
    {


        public override Microsoft.SharePoint.Client.Application.LoginResult Login(System.String @username, System.String @password)
        {
            return LoginEx;
        }
        public Microsoft.SharePoint.Client.Application.LoginResult LoginEx { get; set;}

        public override System.IAsyncResult BeginLogin(System.String @username, System.String @password, System.AsyncCallback @callback, System.Object @asyncState)
        {
            return BeginLoginEx;
        }
        public System.IAsyncResult BeginLoginEx { get; set;}

        public override Microsoft.SharePoint.Client.Application.LoginResult EndLogin(System.IAsyncResult @asyncResult)
        {
            return EndLoginEx;
        }
        public Microsoft.SharePoint.Client.Application.LoginResult EndLoginEx { get; set;}

        public override void LoginAsync(System.String @username, System.String @password)
        {
        }

        public override void LoginAsync(System.String @username, System.String @password, System.Object @userState)
        {
        }

        public override Microsoft.SharePoint.Client.Application.AuthenticationMode Mode()
        {
            return ModeEx;
        }
        public Microsoft.SharePoint.Client.Application.AuthenticationMode ModeEx { get; set;}

        public override System.IAsyncResult BeginMode(System.AsyncCallback @callback, System.Object @asyncState)
        {
            return BeginModeEx;
        }
        public System.IAsyncResult BeginModeEx { get; set;}

        public override Microsoft.SharePoint.Client.Application.AuthenticationMode EndMode(System.IAsyncResult @asyncResult)
        {
            return EndModeEx;
        }
        public Microsoft.SharePoint.Client.Application.AuthenticationMode EndModeEx { get; set;}

        public override void ModeAsync()
        {
        }

        public override void ModeAsync(System.Object @userState)
        {
        }

        public override void CancelAsync(System.Object @userState)
        {
        }

    }
}

