
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration.Internal
{
    public class SPOWebAppServicePrincipalPermissionGrantMock : SPOWebAppServicePrincipalPermissionGrant
    {


        public override System.String ClientId => ClientIdEx;
        public System.String ClientIdEx { get; set; }

        public override System.String ConsentType => ConsentTypeEx;
        public System.String ConsentTypeEx { get; set; }

        public override System.String ObjectId => ObjectIdEx;
        public System.String ObjectIdEx { get; set; }

        public override System.String Resource => ResourceEx;
        public System.String ResourceEx { get; set; }

        public override System.String ResourceId => ResourceIdEx;
        public System.String ResourceIdEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

