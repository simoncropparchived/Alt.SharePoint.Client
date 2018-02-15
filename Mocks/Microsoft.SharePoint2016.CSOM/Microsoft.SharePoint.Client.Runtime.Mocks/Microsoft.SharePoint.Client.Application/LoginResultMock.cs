
namespace Microsoft.SharePoint.Client.Application
{
    public class LoginResultMock : LoginResult
    {


        public override System.String CookieName => CookieNameEx;
        public System.String CookieNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Application.LoginErrorCode ErrorCode => ErrorCodeEx;
        public Microsoft.SharePoint.Client.Application.LoginErrorCode ErrorCodeEx { get; set; }

        public override System.Int32 TimeoutSeconds => TimeoutSecondsEx;
        public System.Int32 TimeoutSecondsEx { get; set; }

    }
}

