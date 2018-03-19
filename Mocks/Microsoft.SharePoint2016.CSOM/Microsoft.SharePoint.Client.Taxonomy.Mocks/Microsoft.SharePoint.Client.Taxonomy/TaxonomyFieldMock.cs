
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomyFieldMock : TaxonomyField
    {


        public override System.Guid AnchorId => AnchorIdEx;
        public System.Guid AnchorIdEx { get; set; }

        public override System.Boolean CreateValuesInEditForm => CreateValuesInEditFormEx;
        public System.Boolean CreateValuesInEditFormEx { get; set; }

        public override System.Boolean IsAnchorValid => IsAnchorValidEx;
        public System.Boolean IsAnchorValidEx { get; set; }

        public override System.Boolean IsKeyword => IsKeywordEx;
        public System.Boolean IsKeywordEx { get; set; }

        public override System.Boolean IsPathRendered => IsPathRenderedEx;
        public System.Boolean IsPathRenderedEx { get; set; }

        public override System.Boolean IsTermSetValid => IsTermSetValidEx;
        public System.Boolean IsTermSetValidEx { get; set; }

        public override System.Boolean Open => OpenEx;
        public System.Boolean OpenEx { get; set; }

        public override System.Guid SspId => SspIdEx;
        public System.Guid SspIdEx { get; set; }

        public override System.String TargetTemplate => TargetTemplateEx;
        public System.String TargetTemplateEx { get; set; }

        public override System.Guid TermSetId => TermSetIdEx;
        public System.Guid TermSetIdEx { get; set; }

        public override System.Guid TextField => TextFieldEx;
        public System.Guid TextFieldEx { get; set; }

        public override System.Boolean UserCreated => UserCreatedEx;
        public System.Boolean UserCreatedEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetFieldValueAsText(System.Object @value)
        {
            return GetFieldValueAsTextEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetFieldValueAsTextEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValue> GetFieldValueAsTaxonomyFieldValue(System.String @value)
        {
            return GetFieldValueAsTaxonomyFieldValueEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValue> GetFieldValueAsTaxonomyFieldValueEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValueCollection GetFieldValueAsTaxonomyFieldValueCollection(System.String @value)
        {
            return GetFieldValueAsTaxonomyFieldValueCollectionEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValueCollection GetFieldValueAsTaxonomyFieldValueCollectionEx { get; set;}

        public override void SetFieldValueByTerm(Microsoft.SharePoint.Client.ListItem @item, Microsoft.SharePoint.Client.Taxonomy.Term @term, System.Int32 @lcid)
        {
        }

        public override void SetFieldValueByTermCollection(Microsoft.SharePoint.Client.ListItem @item, Microsoft.SharePoint.Client.Taxonomy.TermCollection @terms, System.Int32 @lcid)
        {
        }

        public override void SetFieldValueByCollection(Microsoft.SharePoint.Client.ListItem @item, System.Collections.ObjectModel.Collection<Microsoft.SharePoint.Client.Taxonomy.Term> @terms, System.Int32 @lcid)
        {
        }

        public override void SetFieldValueByValue(Microsoft.SharePoint.Client.ListItem @item, Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValue @taxValue)
        {
        }

        public override void SetFieldValueByValueCollection(Microsoft.SharePoint.Client.ListItem @item, Microsoft.SharePoint.Client.Taxonomy.TaxonomyFieldValueCollection @taxValueCollection)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetFieldValueAsHtml(System.Object @value)
        {
            return GetFieldValueAsHtmlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetFieldValueAsHtmlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetValidatedString(System.Object @value)
        {
            return GetValidatedStringEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetValidatedStringEx { get; set;}

    }
}

