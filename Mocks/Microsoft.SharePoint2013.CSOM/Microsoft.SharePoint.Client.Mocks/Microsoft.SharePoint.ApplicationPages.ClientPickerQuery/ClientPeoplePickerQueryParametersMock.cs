
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.ApplicationPages.ClientPickerQuery
{
    public class ClientPeoplePickerQueryParametersMock : ClientPeoplePickerQueryParameters
    {


        public override System.Boolean AllowEmailAddresses => AllowEmailAddressesEx;
        public System.Boolean AllowEmailAddressesEx { get; set; }

        public override System.Boolean AllowMultipleEntities => AllowMultipleEntitiesEx;
        public System.Boolean AllowMultipleEntitiesEx { get; set; }

        public override System.Boolean AllUrlZones => AllUrlZonesEx;
        public System.Boolean AllUrlZonesEx { get; set; }

        public override System.String EnabledClaimProviders => EnabledClaimProvidersEx;
        public System.String EnabledClaimProvidersEx { get; set; }

        public override System.Boolean ForceClaims => ForceClaimsEx;
        public System.Boolean ForceClaimsEx { get; set; }

        public override System.Int32 MaximumEntitySuggestions => MaximumEntitySuggestionsEx;
        public System.Int32 MaximumEntitySuggestionsEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalSource PrincipalSource => PrincipalSourceEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalSource PrincipalSourceEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalType => PrincipalTypeEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalTypeEx { get; set; }

        public override System.String QueryString => QueryStringEx;
        public System.String QueryStringEx { get; set; }

        public override System.Boolean Required => RequiredEx;
        public System.Boolean RequiredEx { get; set; }

        public override System.Int32 SharePointGroupID => SharePointGroupIDEx;
        public System.Int32 SharePointGroupIDEx { get; set; }

        public override Microsoft.SharePoint.Client.UrlZone UrlZone => UrlZoneEx;
        public Microsoft.SharePoint.Client.UrlZone UrlZoneEx { get; set; }

        public override System.Boolean UrlZoneSpecified => UrlZoneSpecifiedEx;
        public System.Boolean UrlZoneSpecifiedEx { get; set; }

        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

        public override System.Guid WebApplicationID => WebApplicationIDEx;
        public System.Guid WebApplicationIDEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

