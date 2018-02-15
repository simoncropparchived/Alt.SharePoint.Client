
namespace Microsoft.Office.Server.Search.REST
{
    public class PromotedResultQueryRuleMock
    {


        public override System.String Contact => ContactEx;
        public System.String ContactEx { get; set; }

        public override System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.ContextCondition> ContextConditions => ContextConditionsEx;
        public System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.ContextCondition> ContextConditionsEx { get; set; }

        public override System.DateTime CreationDate => CreationDateEx;
        public System.DateTime CreationDateEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override System.Boolean IsPromotedResultsOnly => IsPromotedResultsOnlyEx;
        public System.Boolean IsPromotedResultsOnlyEx { get; set; }

        public override System.DateTime LastModifiedDate => LastModifiedDateEx;
        public System.DateTime LastModifiedDateEx { get; set; }

        public override System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.PromotedResults> PromotedResults => PromotedResultsEx;
        public System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.PromotedResults> PromotedResultsEx { get; set; }

        public override System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.QueryCondition> QueryConditions => QueryConditionsEx;
        public System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.QueryCondition> QueryConditionsEx { get; set; }

        public override System.DateTime ReviewDate => ReviewDateEx;
        public System.DateTime ReviewDateEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

