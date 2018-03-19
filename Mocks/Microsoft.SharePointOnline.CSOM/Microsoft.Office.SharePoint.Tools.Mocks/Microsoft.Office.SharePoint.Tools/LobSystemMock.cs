
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class LobSystemMock : LobSystem
    {


        public override System.String Proxy => ProxyEx;
        public System.String ProxyEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.LobSystemInstance[] LobSystemInstances => LobSystemInstancesEx;
        public Microsoft.Office.SharePoint.Tools.LobSystemInstance[] LobSystemInstancesEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.Entity[] Entities => EntitiesEx;
        public Microsoft.Office.SharePoint.Tools.Entity[] EntitiesEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.LobSystemType Type => TypeEx;
        public Microsoft.Office.SharePoint.Tools.LobSystemType TypeEx { get; set; }

    }
}

