
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectDataMock : ClientObjectData
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> PropertiesEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String,System.Object> ClientObjectProperties => ClientObjectPropertiesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> ClientObjectPropertiesEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String,System.Object> MethodReturnObjects => MethodReturnObjectsEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> MethodReturnObjectsEx { get; set; }

    }
}

