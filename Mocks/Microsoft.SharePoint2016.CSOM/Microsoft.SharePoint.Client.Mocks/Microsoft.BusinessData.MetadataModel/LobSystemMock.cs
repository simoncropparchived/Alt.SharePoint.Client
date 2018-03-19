
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class LobSystemMock : LobSystem
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.BusinessData.MetadataModel.Collections.LobSystemInstanceCollection GetLobSystemInstances()
        {
            return GetLobSystemInstancesEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.LobSystemInstanceCollection GetLobSystemInstancesEx { get; set;}

    }
}

