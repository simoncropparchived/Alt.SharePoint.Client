
namespace Microsoft.SharePoint.Client
{
    public class SharePointOnlineCredentialsWebRequestEventArgsMock
    {


        public override System.Net.HttpWebRequest WebRequest => WebRequestEx;
        public System.Net.HttpWebRequest WebRequestEx { get; set; }

    }
}

