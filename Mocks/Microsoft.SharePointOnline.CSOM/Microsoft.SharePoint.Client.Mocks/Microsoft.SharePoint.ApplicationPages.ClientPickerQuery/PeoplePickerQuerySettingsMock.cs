
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.ApplicationPages.ClientPickerQuery
{
    public class PeoplePickerQuerySettingsMock : PeoplePickerQuerySettings
    {


        public override System.Boolean ExcludeAllUsersOnTenantClaim => ExcludeAllUsersOnTenantClaimEx;
        public System.Boolean ExcludeAllUsersOnTenantClaimEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

