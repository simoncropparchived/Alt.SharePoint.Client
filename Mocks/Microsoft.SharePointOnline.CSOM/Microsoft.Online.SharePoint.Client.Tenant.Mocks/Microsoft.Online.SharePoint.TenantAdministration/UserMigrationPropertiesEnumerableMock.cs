
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class UserMigrationPropertiesEnumerableMock : UserMigrationPropertiesEnumerable
    {


        public override System.String NextStartToken => NextStartTokenEx;
        public System.String NextStartTokenEx { get; set; }

    }
}

