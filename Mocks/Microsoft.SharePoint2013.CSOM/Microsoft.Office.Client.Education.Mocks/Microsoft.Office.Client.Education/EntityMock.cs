
namespace Microsoft.Office.Client.Education
{
    public class EntityMock : Entity
    {


        public override System.String CreatedBy => CreatedByEx;
        public System.String CreatedByEx { get; set; }

        public override System.DateTime CreatedDate => CreatedDateEx;
        public System.DateTime CreatedDateEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String EntityId => EntityIdEx;
        public System.String EntityIdEx { get; set; }

        public override System.Int32 ListItemId => ListItemIdEx;
        public System.Int32 ListItemIdEx { get; set; }

        public override System.String ModifiedBy => ModifiedByEx;
        public System.String ModifiedByEx { get; set; }

        public override System.DateTime ModifiedDate => ModifiedDateEx;
        public System.DateTime ModifiedDateEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

