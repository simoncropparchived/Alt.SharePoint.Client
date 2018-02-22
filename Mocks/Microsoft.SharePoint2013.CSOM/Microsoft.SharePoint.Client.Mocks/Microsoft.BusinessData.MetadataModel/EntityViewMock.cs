
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityViewMock : EntityView
    {


        public override Microsoft.BusinessData.MetadataModel.Collections.EntityFieldCollection Fields => FieldsEx;
        public Microsoft.BusinessData.MetadataModel.Collections.EntityFieldCollection FieldsEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String RelatedSpecificFinderName => RelatedSpecificFinderNameEx;
        public System.String RelatedSpecificFinderNameEx { get; set; }

        public override Microsoft.BusinessData.Runtime.EntityFieldValueDictionary GetDefaultValues()
        {
            return GetDefaultValuesEx;
        }
        public Microsoft.BusinessData.Runtime.EntityFieldValueDictionary GetDefaultValuesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetXmlSchema()
        {
            return GetXmlSchemaEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetXmlSchemaEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.TypeDescriptor GetTypeDescriptor(System.String @fieldDotNotation)
        {
            return GetTypeDescriptorEx;
        }
        public Microsoft.BusinessData.MetadataModel.TypeDescriptor GetTypeDescriptorEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetType(System.String @fieldDotNotation)
        {
            return GetTypeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetTypeEx { get; set;}

    }
}

