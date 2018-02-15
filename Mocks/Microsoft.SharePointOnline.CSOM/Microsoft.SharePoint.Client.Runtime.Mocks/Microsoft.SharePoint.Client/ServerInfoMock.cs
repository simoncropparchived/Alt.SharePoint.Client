
namespace Microsoft.SharePoint.Client
{
    public class ServerInfoMock
    {


        public override System.Web.Configuration.AuthenticationMode AuthenticationMode => AuthenticationModeEx;
        public System.Web.Configuration.AuthenticationMode AuthenticationModeEx { get; set; }

    }
}

