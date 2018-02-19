
namespace Microsoft.BusinessData.Runtime
{
    public class EntityFieldValueDictionaryMock : EntityFieldValueDictionary
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

    }
}

