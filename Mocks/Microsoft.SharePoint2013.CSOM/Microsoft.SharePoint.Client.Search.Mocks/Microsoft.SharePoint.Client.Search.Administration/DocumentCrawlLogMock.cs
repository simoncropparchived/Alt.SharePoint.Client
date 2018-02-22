
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Administration
{
    public class DocumentCrawlLogMock : DocumentCrawlLog
    {


        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.SimpleDataTable> GetCrawledUrls(System.Boolean @getCountOnly, System.Int64 @maxRows, System.String @queryString, System.Boolean @isLike, System.Int32 @contentSourceID, System.Int32 @errorLevel, System.Int32 @errorID, System.DateTime @startDateTime, System.DateTime @endDateTime)
        {
            return GetCrawledUrlsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.SimpleDataTable> GetCrawledUrlsEx { get; set;}

    }
}

