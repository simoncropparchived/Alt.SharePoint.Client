
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class ResultTableMock : ResultTable
    {


        public override System.String GroupTemplateId => GroupTemplateIdEx;
        public System.String GroupTemplateIdEx { get; set; }

        public override System.String ItemTemplateId => ItemTemplateIdEx;
        public System.String ItemTemplateIdEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.Object> PropertiesEx { get; set; }

        public override System.String QueryId => QueryIdEx;
        public System.String QueryIdEx { get; set; }

        public override System.String QueryRuleId => QueryRuleIdEx;
        public System.String QueryRuleIdEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.Collections.Generic.IDictionary<System.String,System.Object>> ResultRows => ResultRowsEx;
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.IDictionary<System.String,System.Object>> ResultRowsEx { get; set; }

        public override System.String ResultTitle => ResultTitleEx;
        public System.String ResultTitleEx { get; set; }

        public override System.String ResultTitleUrl => ResultTitleUrlEx;
        public System.String ResultTitleUrlEx { get; set; }

        public override System.Int32 RowCount => RowCountEx;
        public System.Int32 RowCountEx { get; set; }

        public override System.String TableType => TableTypeEx;
        public System.String TableTypeEx { get; set; }

        public override System.Int32 TotalRows => TotalRowsEx;
        public System.Int32 TotalRowsEx { get; set; }

        public override System.Int32 TotalRowsIncludingDuplicates => TotalRowsIncludingDuplicatesEx;
        public System.Int32 TotalRowsIncludingDuplicatesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

