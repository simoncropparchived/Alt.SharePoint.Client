
namespace Microsoft.BusinessData.Runtime
{
    public class EntityInstanceMock : EntityInstance
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


    }
}

