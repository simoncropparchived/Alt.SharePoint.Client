
namespace Microsoft.SharePoint.Client
{
    public class ExternalApplicationRequestTokenMock
    {


        public override System.Int32 Version => VersionEx;
        public System.Int32 VersionEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.Int32 UserId => UserIdEx;
        public System.Int32 UserIdEx { get; set; }

        public override System.Guid ApplicationId => ApplicationIdEx;
        public System.Guid ApplicationIdEx { get; set; }

        public override System.String ApplicationPrincipalLogOnName => ApplicationPrincipalLogOnNameEx;
        public System.String ApplicationPrincipalLogOnNameEx { get; set; }

        public override System.DateTime DateTime => DateTimeEx;
        public System.DateTime DateTimeEx { get; set; }

        public override System.Byte[] ClientHash => ClientHashEx;
        public System.Byte[] ClientHashEx { get; set; }

        public override System.Byte[] ServerHash => ServerHashEx;
        public System.Byte[] ServerHashEx { get; set; }

        public override System.String TokenPrefix => TokenPrefixEx;
        public System.String TokenPrefixEx { get; set; }

    }
}

