
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.Runtime
{
    public class EntityFieldValueDictionaryMock : EntityFieldValueDictionary
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override void RefreshLoad()
        {
        }

        public override void FromXml(System.String @xml)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ToXml()
        {
            return ToXmlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ToXmlEx { get; set;}

        public override void CreateInstance(System.String @fieldInstanceDotNotation, System.String @fieldDotNotation)
        {
        }

        public override void CreateCollectionInstance(System.String @fieldDotNotation, System.Int32 @size)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetCollectionSize(System.String @fieldDotNotation)
        {
            return GetCollectionSizeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetCollectionSizeEx { get; set;}

    }
}

