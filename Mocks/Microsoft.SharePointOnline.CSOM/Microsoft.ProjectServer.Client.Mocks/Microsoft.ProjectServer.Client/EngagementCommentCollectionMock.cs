
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EngagementCommentCollectionMock : EngagementCommentCollection
    {


        public override Microsoft.ProjectServer.Client.EngagementComment Add(System.String @comment)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.EngagementComment AddEx { get; set;}

    }
}

