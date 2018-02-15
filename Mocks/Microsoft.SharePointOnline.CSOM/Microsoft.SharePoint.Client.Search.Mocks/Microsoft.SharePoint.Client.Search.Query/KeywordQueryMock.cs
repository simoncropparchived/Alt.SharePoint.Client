
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class KeywordQueryMock
    {


        public override System.String CollapseSpecification => CollapseSpecificationEx;
        public System.String CollapseSpecificationEx { get; set; }

        public override System.Boolean EnableSorting => EnableSortingEx;
        public System.Boolean EnableSortingEx { get; set; }

        public override System.String HiddenConstraints => HiddenConstraintsEx;
        public System.String HiddenConstraintsEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.KeywordQueryProperties Properties => PropertiesEx;
        public Microsoft.SharePoint.Client.Search.Query.KeywordQueryProperties PropertiesEx { get; set; }

        public override System.String OLSQuerySession => OLSQuerySessionEx;
        public System.String OLSQuerySessionEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.StringCollection RefinementFilters => RefinementFiltersEx;
        public Microsoft.SharePoint.Client.Search.Query.StringCollection RefinementFiltersEx { get; set; }

        public override System.String Refiners => RefinersEx;
        public System.String RefinersEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.ReorderingRuleCollection ReorderingRules => ReorderingRulesEx;
        public Microsoft.SharePoint.Client.Search.Query.ReorderingRuleCollection ReorderingRulesEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.StringCollection SelectProperties => SelectPropertiesEx;
        public Microsoft.SharePoint.Client.Search.Query.StringCollection SelectPropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.SortCollection SortList => SortListEx;
        public Microsoft.SharePoint.Client.Search.Query.SortCollection SortListEx { get; set; }

        public override System.Int32 TimeZoneId => TimeZoneIdEx;
        public System.Int32 TimeZoneIdEx { get; set; }

        public override System.Int64 TrimDuplicatesIncludeId => TrimDuplicatesIncludeIdEx;
        public System.Int64 TrimDuplicatesIncludeIdEx { get; set; }

        public override System.Int32 UseOLSQuery => UseOLSQueryEx;
        public System.Int32 UseOLSQueryEx { get; set; }

    }
}

