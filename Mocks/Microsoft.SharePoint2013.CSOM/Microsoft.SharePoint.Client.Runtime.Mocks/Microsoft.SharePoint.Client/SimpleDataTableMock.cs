
namespace Microsoft.SharePoint.Client
{
    public class SimpleDataTableMock : SimpleDataTable
    {


        public override System.Collections.ObjectModel.Collection<System.Collections.Generic.Dictionary<System.String,System.Object>> Rows => RowsEx;
        public System.Collections.ObjectModel.Collection<System.Collections.Generic.Dictionary<System.String,System.Object>> RowsEx { get; set; }

    }
}

