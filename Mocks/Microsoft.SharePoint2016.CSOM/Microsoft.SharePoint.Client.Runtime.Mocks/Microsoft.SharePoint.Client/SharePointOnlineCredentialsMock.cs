
namespace Microsoft.SharePoint.Client
{
    public class SharePointOnlineCredentialsMock : SharePointOnlineCredentials
    {


        public override System.String UserName => UserNameEx;
        public System.String UserNameEx { get; set; }

    }
}

