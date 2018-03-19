
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class RankingLabelingMock : RankingLabeling
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String, System.Int32>> GetJudgementsForQuery(System.String @query)
        {
            return GetJudgementsForQueryEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String, System.Int32>> GetJudgementsForQueryEx { get; set;}

        public override void AddJudgment(System.String @userQuery, System.String @url, System.Int16 @labelId)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> NormalizeResultUrl(System.String @url)
        {
            return NormalizeResultUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> NormalizeResultUrlEx { get; set;}

    }
}

