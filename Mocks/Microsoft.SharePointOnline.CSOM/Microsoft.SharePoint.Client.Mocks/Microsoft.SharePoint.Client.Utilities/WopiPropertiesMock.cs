
namespace Microsoft.SharePoint.Client.Utilities
{
    public class WopiPropertiesMock : WopiProperties
    {


        public override System.String AccessToken => AccessTokenEx;
        public System.String AccessTokenEx { get; set; }

        public override System.Int64 AccessTokenTtl => AccessTokenTtlEx;
        public System.Int64 AccessTokenTtlEx { get; set; }

        public override System.String AppIconUrl => AppIconUrlEx;
        public System.String AppIconUrlEx { get; set; }

        public override System.String ErrorMessageToDisplay => ErrorMessageToDisplayEx;
        public System.String ErrorMessageToDisplayEx { get; set; }

        public override System.String RedirectUrl => RedirectUrlEx;
        public System.String RedirectUrlEx { get; set; }

        public override System.String WebApplicationUrl => WebApplicationUrlEx;
        public System.String WebApplicationUrlEx { get; set; }

    }
}

