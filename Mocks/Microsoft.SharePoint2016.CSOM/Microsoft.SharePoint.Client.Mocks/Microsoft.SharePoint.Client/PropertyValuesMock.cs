
namespace Microsoft.SharePoint.Client
{
    public class PropertyValuesMock
    {


        public override System.Collections.Generic.Dictionary`2<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary`2<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object Item => ItemEx;
        public System.Object ItemEx { get; set; }

    }
}

