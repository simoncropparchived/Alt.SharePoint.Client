
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StatusAssignmentHistoryLineMock : StatusAssignmentHistoryLine
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusApprovalType Decision => DecisionEx;
        public Microsoft.ProjectServer.Client.StatusApprovalType DecisionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.DateTime Submitted => SubmittedEx;
        public System.DateTime SubmittedEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusUpdateType UpdateType => UpdateTypeEx;
        public Microsoft.ProjectServer.Client.StatusUpdateType UpdateTypeEx { get; set; }

    }
}

