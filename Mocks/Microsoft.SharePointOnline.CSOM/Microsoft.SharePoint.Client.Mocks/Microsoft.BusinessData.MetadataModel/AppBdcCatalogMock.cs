
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class AppBdcCatalogMock : AppBdcCatalog
    {


        public override Microsoft.BusinessData.MetadataModel.Entity GetEntity(System.String @namespace, System.String @name)
        {
            return GetEntityEx;
        }
        public Microsoft.BusinessData.MetadataModel.Entity GetEntityEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetLobSystemProperty(System.String @lobSystemName, System.String @propertyName)
        {
            return GetLobSystemPropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetLobSystemPropertyEx { get; set;}

        public override void SetLobSystemProperty(System.String @lobSystemName, System.String @propertyName, System.String @propertyValue)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetLobSystemInstanceProperty(System.String @lobSystemName, System.String @lobSystemInstanceName, System.String @propertyName)
        {
            return GetLobSystemInstancePropertyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetLobSystemInstancePropertyEx { get; set;}

        public override void SetLobSystemInstanceProperty(System.String @lobSystemName, System.String @lobSystemInstanceName, System.String @propertyName, System.String @propertyValue)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetConnectionId(System.String @lobSystemName, System.String @lobSystemInstanceName)
        {
            return GetConnectionIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetConnectionIdEx { get; set;}

        public override void SetConnectionId(System.String @lobSystemName, System.String @lobSystemInstanceName, System.String @connectionId)
        {
        }

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPermissibleConnections()
        {
            return GetPermissibleConnectionsEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPermissibleConnectionsEx { get; set;}

    }
}

