
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldMock : Field
    {


        public override System.Boolean AutoIndexed => AutoIndexedEx;
        public System.Boolean AutoIndexedEx { get; set; }

        public override System.Boolean CanBeDeleted => CanBeDeletedEx;
        public System.Boolean CanBeDeletedEx { get; set; }

        public override System.Guid ClientSideComponentId => ClientSideComponentIdEx;
        public System.Guid ClientSideComponentIdEx { get; set; }

        public override System.String ClientSideComponentProperties => ClientSideComponentPropertiesEx;
        public System.String ClientSideComponentPropertiesEx { get; set; }

        public override System.String CustomFormatter => CustomFormatterEx;
        public System.String CustomFormatterEx { get; set; }

        public override System.String DefaultFormula => DefaultFormulaEx;
        public System.String DefaultFormulaEx { get; set; }

        public override System.String DefaultValue => DefaultValueEx;
        public System.String DefaultValueEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource DescriptionResource => DescriptionResourceEx;
        public Microsoft.SharePoint.Client.UserResource DescriptionResourceEx { get; set; }

        public override System.String Direction => DirectionEx;
        public System.String DirectionEx { get; set; }

        public override System.Boolean EnforceUniqueValues => EnforceUniqueValuesEx;
        public System.Boolean EnforceUniqueValuesEx { get; set; }

        public override System.String EntityPropertyName => EntityPropertyNameEx;
        public System.String EntityPropertyNameEx { get; set; }

        public override System.Boolean Filterable => FilterableEx;
        public System.Boolean FilterableEx { get; set; }

        public override System.Boolean FromBaseType => FromBaseTypeEx;
        public System.Boolean FromBaseTypeEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean Indexed => IndexedEx;
        public System.Boolean IndexedEx { get; set; }

        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.String JSLink => JSLinkEx;
        public System.String JSLinkEx { get; set; }

        public override System.Boolean NoCrawl => NoCrawlEx;
        public System.Boolean NoCrawlEx { get; set; }

        public override System.Boolean PinnedToFiltersPane => PinnedToFiltersPaneEx;
        public System.Boolean PinnedToFiltersPaneEx { get; set; }

        public override System.Boolean ReadOnlyField => ReadOnlyFieldEx;
        public System.Boolean ReadOnlyFieldEx { get; set; }

        public override System.Boolean Required => RequiredEx;
        public System.Boolean RequiredEx { get; set; }

        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

        public override System.String SchemaXmlWithResourceTokens => SchemaXmlWithResourceTokensEx;
        public System.String SchemaXmlWithResourceTokensEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

        public override System.Boolean Sealed => SealedEx;
        public System.Boolean SealedEx { get; set; }

        public override Microsoft.SharePoint.Client.ShowInFiltersPaneStatus ShowInFiltersPane => ShowInFiltersPaneEx;
        public Microsoft.SharePoint.Client.ShowInFiltersPaneStatus ShowInFiltersPaneEx { get; set; }

        public override System.Boolean Sortable => SortableEx;
        public System.Boolean SortableEx { get; set; }

        public override System.String StaticName => StaticNameEx;
        public System.String StaticNameEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource TitleResource => TitleResourceEx;
        public Microsoft.SharePoint.Client.UserResource TitleResourceEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldType FieldTypeKind => FieldTypeKindEx;
        public Microsoft.SharePoint.Client.FieldType FieldTypeKindEx { get; set; }

        public override System.String TypeAsString => TypeAsStringEx;
        public System.String TypeAsStringEx { get; set; }

        public override System.String TypeDisplayName => TypeDisplayNameEx;
        public System.String TypeDisplayNameEx { get; set; }

        public override System.String TypeShortDescription => TypeShortDescriptionEx;
        public System.String TypeShortDescriptionEx { get; set; }

        public override System.String ValidationFormula => ValidationFormulaEx;
        public System.String ValidationFormulaEx { get; set; }

        public override System.String ValidationMessage => ValidationMessageEx;
        public System.String ValidationMessageEx { get; set; }

        public override void ValidateSetValue(Microsoft.SharePoint.Client.ListItem @item, System.String @value)
        {
        }

        public override void UpdateAndPushChanges(System.Boolean @pushChangesToLists)
        {
        }

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

        public override void SetShowInDisplayForm(System.Boolean @value)
        {
        }

        public override void SetShowInEditForm(System.Boolean @value)
        {
        }

        public override void SetShowInNewForm(System.Boolean @value)
        {
        }

    }
}

