
namespace Microsoft.SharePoint.Client
{
    public class RelatedFieldMock : RelatedField
    {


        public override System.Guid FieldId => FieldIdEx;
        public System.Guid FieldIdEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override Microsoft.SharePoint.Client.List LookupList => LookupListEx;
        public Microsoft.SharePoint.Client.List LookupListEx { get; set; }

        public override Microsoft.SharePoint.Client.RelationshipDeleteBehaviorType RelationshipDeleteBehavior => RelationshipDeleteBehaviorEx;
        public Microsoft.SharePoint.Client.RelationshipDeleteBehaviorType RelationshipDeleteBehaviorEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

