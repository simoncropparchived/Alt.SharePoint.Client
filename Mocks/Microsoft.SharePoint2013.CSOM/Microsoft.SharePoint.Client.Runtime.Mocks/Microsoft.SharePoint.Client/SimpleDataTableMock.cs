
namespace Microsoft.SharePoint.Client
{
    public class SimpleDataTableMock
    {


        public override System.Collections.ObjectModel.Collection`1<System.Collections.Generic.Dictionary`2<System.String,System.Object>> Rows => RowsEx;
        public System.Collections.ObjectModel.Collection`1<System.Collections.Generic.Dictionary`2<System.String,System.Object>> RowsEx { get; set; }

    }
}

