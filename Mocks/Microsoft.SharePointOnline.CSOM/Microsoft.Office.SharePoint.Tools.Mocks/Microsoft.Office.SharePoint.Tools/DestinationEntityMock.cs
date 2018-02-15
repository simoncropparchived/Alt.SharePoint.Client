
namespace Microsoft.Office.SharePoint.Tools
{
    public class DestinationEntityMock : DestinationEntity
    {


        public override System.String Namespace => NamespaceEx;
        public System.String NamespaceEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

