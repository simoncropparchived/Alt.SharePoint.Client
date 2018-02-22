
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class SearchExecutorMock : SearchExecutor
    {


        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.ResultTableCollection> ExecuteQuery(Microsoft.SharePoint.Client.Search.Query.Query @query)
        {
            return ExecuteQueryEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.ResultTableCollection> ExecuteQueryEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String,Microsoft.SharePoint.Client.Search.Query.ResultTableCollection>> ExecuteQueries(System.String[] @queryIds, Microsoft.SharePoint.Client.Search.Query.Query[] @queries, System.Boolean @handleExceptions)
        {
            return ExecuteQueriesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String,Microsoft.SharePoint.Client.Search.Query.ResultTableCollection>> ExecuteQueriesEx { get; set;}

        public override void RecordPageClick(System.String @pageInfo, System.String @clickType, System.Int32 @blockType, System.String @clickedResultId, System.Int32 @subResultIndex, System.String @immediacySourceId, System.String @immediacyQueryString, System.String @immediacyTitle, System.String @immediacyUrl)
        {
        }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Search.Query.PopularQuery> ExportPopularQueries(Microsoft.SharePoint.Client.Web @web, System.Guid @sourceId)
        {
            return ExportPopularQueriesEx;
        }
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Search.Query.PopularQuery> ExportPopularQueriesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Server.Search.REST.PromotedResultsOperationsResult> GetPromotedResults(System.Boolean @siteCollectionLevel, System.Int32 @offset, System.Int32 @numberOfRules)
        {
            return GetPromotedResultsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Server.Search.REST.PromotedResultsOperationsResult> GetPromotedResultsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Server.Search.REST.QueryConfiguration> GetQueryConfiguration(System.Boolean @callLocalSearchFarmsOnly)
        {
            return GetQueryConfigurationEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Server.Search.REST.QueryConfiguration> GetQueryConfigurationEx { get; set;}

    }
}

