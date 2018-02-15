
namespace Microsoft.ProjectServer.Client
{
    public class EngagementCommentMock : EngagementComment
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Message => MessageEx;
        public System.String MessageEx { get; set; }

    }
}

