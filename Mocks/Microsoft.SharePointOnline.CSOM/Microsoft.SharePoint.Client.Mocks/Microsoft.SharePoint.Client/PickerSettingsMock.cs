
namespace Microsoft.SharePoint.Client
{
    public class PickerSettingsMock
    {


        public override System.Boolean AllowEmailAddresses => AllowEmailAddressesEx;
        public System.Boolean AllowEmailAddressesEx { get; set; }

        public override System.Boolean AllowOnlyEmailAddresses => AllowOnlyEmailAddressesEx;
        public System.Boolean AllowOnlyEmailAddressesEx { get; set; }

        public override System.String PrincipalAccountType => PrincipalAccountTypeEx;
        public System.String PrincipalAccountTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalSource PrincipalSource => PrincipalSourceEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalSource PrincipalSourceEx { get; set; }

        public override Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.PeoplePickerQuerySettings QuerySettings => QuerySettingsEx;
        public Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.PeoplePickerQuerySettings QuerySettingsEx { get; set; }

        public override System.Int32 VisibleSuggestions => VisibleSuggestionsEx;
        public System.Int32 VisibleSuggestionsEx { get; set; }

    }
}

