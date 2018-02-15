
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectDataMock
    {


        public override System.Collections.Generic.Dictionary`2<System.String,System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.Dictionary`2<System.String,System.Object> PropertiesEx { get; set; }

        public override System.Collections.Generic.Dictionary`2<System.String,System.Object> ClientObjectProperties => ClientObjectPropertiesEx;
        public System.Collections.Generic.Dictionary`2<System.String,System.Object> ClientObjectPropertiesEx { get; set; }

        public override System.Collections.Generic.Dictionary`2<System.String,System.Object> MethodReturnObjects => MethodReturnObjectsEx;
        public System.Collections.Generic.Dictionary`2<System.String,System.Object> MethodReturnObjectsEx { get; set; }

    }
}

