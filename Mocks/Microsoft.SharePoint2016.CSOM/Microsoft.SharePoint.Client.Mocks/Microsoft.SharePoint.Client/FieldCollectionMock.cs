
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldCollectionMock : FieldCollection
    {


        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

        public override Microsoft.SharePoint.Client.Field GetByTitle(System.String @title)
        {
            return GetByTitleEx;
        }
        public Microsoft.SharePoint.Client.Field GetByTitleEx { get; set;}

        public override Microsoft.SharePoint.Client.Field GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Field GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Field Add(Microsoft.SharePoint.Client.Field @field)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Field AddEx { get; set;}

        public override Microsoft.SharePoint.Client.Field AddDependentLookup(System.String @displayName, Microsoft.SharePoint.Client.Field @primaryLookupField, System.String @lookupField)
        {
            return AddDependentLookupEx;
        }
        public Microsoft.SharePoint.Client.Field AddDependentLookupEx { get; set;}

        public override Microsoft.SharePoint.Client.Field AddFieldAsXml(System.String @schemaXml, System.Boolean @addToDefaultView, Microsoft.SharePoint.Client.AddFieldOptions @options)
        {
            return AddFieldAsXmlEx;
        }
        public Microsoft.SharePoint.Client.Field AddFieldAsXmlEx { get; set;}

        public override Microsoft.SharePoint.Client.Field GetByInternalNameOrTitle(System.String @strName)
        {
            return GetByInternalNameOrTitleEx;
        }
        public Microsoft.SharePoint.Client.Field GetByInternalNameOrTitleEx { get; set;}

    }
}

