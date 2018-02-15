
namespace Microsoft.SharePoint.Client
{
    public class SharePointOnlineCredentialsWebRequestEventArgsMock : SharePointOnlineCredentialsWebRequestEventArgs
    {


        public override System.Net.HttpWebRequest WebRequest => WebRequestEx;
        public System.Net.HttpWebRequest WebRequestEx { get; set; }

    }
}

