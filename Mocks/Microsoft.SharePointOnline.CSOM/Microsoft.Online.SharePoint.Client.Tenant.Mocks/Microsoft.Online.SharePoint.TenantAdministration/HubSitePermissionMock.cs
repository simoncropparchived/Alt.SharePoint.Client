
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class HubSitePermissionMock : HubSitePermission
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String PrincipalName => PrincipalNameEx;
        public System.String PrincipalNameEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOHubSiteUserRights Rights => RightsEx;
        public Microsoft.Online.SharePoint.TenantAdministration.SPOHubSiteUserRights RightsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

