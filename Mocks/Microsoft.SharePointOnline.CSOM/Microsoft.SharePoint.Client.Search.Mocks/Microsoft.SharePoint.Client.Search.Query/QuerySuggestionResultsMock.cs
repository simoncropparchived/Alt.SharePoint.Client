
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QuerySuggestionResultsMock : QuerySuggestionResults
    {


        public override System.String[] PeopleNames => PeopleNamesEx;
        public System.String[] PeopleNamesEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.PersonalResultSuggestion[] PersonalResults => PersonalResultsEx;
        public Microsoft.SharePoint.Client.Search.Query.PersonalResultSuggestion[] PersonalResultsEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.QuerySuggestionQuery[] Queries => QueriesEx;
        public Microsoft.SharePoint.Client.Search.Query.QuerySuggestionQuery[] QueriesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

