
namespace Microsoft.SharePoint.ApplicationPages.ClientPickerQuery
{
    public class PeoplePickerQuerySettingsMock
    {


        public override System.Boolean ExcludeAllUsersOnTenantClaim => ExcludeAllUsersOnTenantClaimEx;
        public System.Boolean ExcludeAllUsersOnTenantClaimEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

