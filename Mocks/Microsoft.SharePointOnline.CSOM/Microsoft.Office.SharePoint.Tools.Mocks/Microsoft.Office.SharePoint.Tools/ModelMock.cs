
namespace Microsoft.Office.SharePoint.Tools
{
    public class ModelMock : Model
    {


        public override Microsoft.Office.SharePoint.Tools.LobSystem[] LobSystems => LobSystemsEx;
        public Microsoft.Office.SharePoint.Tools.LobSystem[] LobSystemsEx { get; set; }

    }
}

