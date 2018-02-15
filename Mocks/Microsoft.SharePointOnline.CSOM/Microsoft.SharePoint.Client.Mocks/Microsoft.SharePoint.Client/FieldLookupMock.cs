
namespace Microsoft.SharePoint.Client
{
    public class FieldLookupMock
    {


        public override System.Boolean AllowMultipleValues => AllowMultipleValuesEx;
        public System.Boolean AllowMultipleValuesEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> DependentLookupInternalNames => DependentLookupInternalNamesEx;
        public System.Collections.Generic.IList`1<System.String> DependentLookupInternalNamesEx { get; set; }

        public override System.Boolean IsDependentLookup => IsDependentLookupEx;
        public System.Boolean IsDependentLookupEx { get; set; }

        public override System.Boolean IsRelationship => IsRelationshipEx;
        public System.Boolean IsRelationshipEx { get; set; }

        public override System.String LookupField => LookupFieldEx;
        public System.String LookupFieldEx { get; set; }

        public override System.String LookupList => LookupListEx;
        public System.String LookupListEx { get; set; }

        public override System.Guid LookupWebId => LookupWebIdEx;
        public System.Guid LookupWebIdEx { get; set; }

        public override System.String PrimaryFieldId => PrimaryFieldIdEx;
        public System.String PrimaryFieldIdEx { get; set; }

        public override Microsoft.SharePoint.Client.RelationshipDeleteBehaviorType RelationshipDeleteBehavior => RelationshipDeleteBehaviorEx;
        public Microsoft.SharePoint.Client.RelationshipDeleteBehaviorType RelationshipDeleteBehaviorEx { get; set; }

        public override System.Boolean UnlimitedLengthInDocumentLibrary => UnlimitedLengthInDocumentLibraryEx;
        public System.Boolean UnlimitedLengthInDocumentLibraryEx { get; set; }

    }
}

