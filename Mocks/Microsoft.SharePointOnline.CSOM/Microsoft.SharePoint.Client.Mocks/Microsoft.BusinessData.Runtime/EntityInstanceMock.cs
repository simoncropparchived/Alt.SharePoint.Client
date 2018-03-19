
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.Runtime
{
    public class EntityInstanceMock : EntityInstance
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override void RefreshLoad()
        {
        }

        public override void CreateInstance(System.String @fieldInstanceDotNotation, System.String @fieldDotNotation)
        {
        }

        public override void CreateCollectionInstance(System.String @fieldDotNotation, System.Int32 @size)
        {
        }

        public override Microsoft.BusinessData.Runtime.EntityIdentity GetIdentity()
        {
            return GetIdentityEx;
        }
        public Microsoft.BusinessData.Runtime.EntityIdentity GetIdentityEx { get; set;}

        public override void DeleteObject()
        {
        }

        public override void Update()
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

    }
}

