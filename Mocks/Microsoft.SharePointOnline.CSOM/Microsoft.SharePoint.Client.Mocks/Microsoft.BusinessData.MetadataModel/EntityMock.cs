
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityMock
    {


        public override System.Int64 EstimatedInstanceCount => EstimatedInstanceCountEx;
        public System.Int64 EstimatedInstanceCountEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Namespace => NamespaceEx;
        public System.String NamespaceEx { get; set; }

    }
}

