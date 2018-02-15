
namespace Microsoft.SharePoint.Client
{
    public class ListDataSourceMock
    {


        public override System.Collections.Generic.IDictionary`2<System.String,System.String> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> PropertiesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

