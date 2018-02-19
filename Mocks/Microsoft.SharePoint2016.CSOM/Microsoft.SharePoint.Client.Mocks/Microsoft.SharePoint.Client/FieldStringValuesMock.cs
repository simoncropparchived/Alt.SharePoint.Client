
namespace Microsoft.SharePoint.Client
{
    public class FieldStringValuesMock : FieldStringValues
    {


        public override System.Collections.Generic.Dictionary<System.String,System.String> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.String> FieldValuesEx { get; set; }

    }
}

