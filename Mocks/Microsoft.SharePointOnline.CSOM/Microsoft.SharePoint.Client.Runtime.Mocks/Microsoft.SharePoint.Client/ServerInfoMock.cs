
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ServerInfoMock : ServerInfo
    {


        public override System.Web.Configuration.AuthenticationMode AuthenticationMode => AuthenticationModeEx;
        public System.Web.Configuration.AuthenticationMode AuthenticationModeEx { get; set; }

    }
}

