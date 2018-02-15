
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class UserMigrationPropertiesEnumerableFilterMock : UserMigrationPropertiesEnumerableFilter
    {


        public override System.String StartToken => StartTokenEx;
        public System.String StartTokenEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

