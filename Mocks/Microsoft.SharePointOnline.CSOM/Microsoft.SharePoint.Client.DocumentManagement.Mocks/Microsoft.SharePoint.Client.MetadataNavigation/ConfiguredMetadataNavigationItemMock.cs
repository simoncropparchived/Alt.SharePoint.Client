
namespace Microsoft.SharePoint.Client.MetadataNavigation
{
    public class ConfiguredMetadataNavigationItemMock
    {


        public override System.String FieldDisplayName => FieldDisplayNameEx;
        public System.String FieldDisplayNameEx { get; set; }

        public override System.String FieldTitle => FieldTitleEx;
        public System.String FieldTitleEx { get; set; }

        public override System.String FieldTypeAsString => FieldTypeAsStringEx;
        public System.String FieldTypeAsStringEx { get; set; }

        public override System.Boolean IsContentTypeField => IsContentTypeFieldEx;
        public System.Boolean IsContentTypeFieldEx { get; set; }

        public override System.Boolean IsFolderHierarchy => IsFolderHierarchyEx;
        public System.Boolean IsFolderHierarchyEx { get; set; }

        public override System.Boolean IsHierarchy => IsHierarchyEx;
        public System.Boolean IsHierarchyEx { get; set; }

        public override System.Boolean IsMultiValueLookup => IsMultiValueLookupEx;
        public System.Boolean IsMultiValueLookupEx { get; set; }

        public override System.Boolean IsTaxonomyField => IsTaxonomyFieldEx;
        public System.Boolean IsTaxonomyFieldEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

