
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteEntityInstanceEventPropertiesMock : SPRemoteEntityInstanceEventProperties
    {


        public override System.String EntityName => EntityNameEx;
        public System.String EntityNameEx { get; set; }

        public override System.String EntityNamespace => EntityNamespaceEx;
        public System.String EntityNamespaceEx { get; set; }

        public override System.String NotificationContext => NotificationContextEx;
        public System.String NotificationContextEx { get; set; }

        public override System.String LobSystemInstanceName => LobSystemInstanceNameEx;
        public System.String LobSystemInstanceNameEx { get; set; }

        public override System.Byte[] NotificationMessage => NotificationMessageEx;
        public System.Byte[] NotificationMessageEx { get; set; }

    }
}

