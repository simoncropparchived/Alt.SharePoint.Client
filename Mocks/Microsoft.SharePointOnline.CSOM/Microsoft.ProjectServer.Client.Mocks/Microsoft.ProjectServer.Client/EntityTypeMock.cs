
namespace Microsoft.ProjectServer.Client
{
    public class EntityTypeMock : EntityType
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Guid ID => IDEx;
        public System.Guid IDEx { get; set; }

    }
}

