
namespace Microsoft.SharePoint.Client
{
    public class FieldStringValuesMock
    {


        public override System.Collections.Generic.Dictionary`2<System.String,System.String> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary`2<System.String,System.String> FieldValuesEx { get; set; }

        public override System.String Item => ItemEx;
        public System.String ItemEx { get; set; }

    }
}

