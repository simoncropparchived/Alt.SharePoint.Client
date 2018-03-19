
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Application
{
    public class LoginCompletedEventArgsMock : LoginCompletedEventArgs
    {


        public override Microsoft.SharePoint.Client.Application.LoginResult Result => ResultEx;
        public Microsoft.SharePoint.Client.Application.LoginResult ResultEx { get; set; }

    }
}

