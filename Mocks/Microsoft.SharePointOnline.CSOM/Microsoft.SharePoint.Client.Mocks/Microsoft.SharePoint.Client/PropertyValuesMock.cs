
namespace Microsoft.SharePoint.Client
{
    public class PropertyValuesMock : PropertyValues
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

    }
}

