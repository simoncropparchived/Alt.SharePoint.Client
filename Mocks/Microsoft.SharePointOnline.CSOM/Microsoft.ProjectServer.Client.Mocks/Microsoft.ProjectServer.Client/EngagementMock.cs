
namespace Microsoft.ProjectServer.Client
{
    public class EngagementMock
    {


        public override Microsoft.ProjectServer.Client.EngagementCommentCollection Comments => CommentsEx;
        public Microsoft.ProjectServer.Client.EngagementCommentCollection CommentsEx { get; set; }

        public override System.DateTime CreatedDate => CreatedDateEx;
        public System.DateTime CreatedDateEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override Microsoft.SharePoint.Client.User ModifiedBy => ModifiedByEx;
        public Microsoft.SharePoint.Client.User ModifiedByEx { get; set; }

        public override Microsoft.ProjectServer.Client.Project Project => ProjectEx;
        public Microsoft.ProjectServer.Client.Project ProjectEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResource Resource => ResourceEx;
        public Microsoft.ProjectServer.Client.EnterpriseResource ResourceEx { get; set; }

        public override Microsoft.SharePoint.Client.User ReviewedBy => ReviewedByEx;
        public Microsoft.SharePoint.Client.User ReviewedByEx { get; set; }

        public override System.DateTime ReviewedDate => ReviewedDateEx;
        public System.DateTime ReviewedDateEx { get; set; }

        public override Microsoft.ProjectServer.Client.EngagementStatus Status => StatusEx;
        public Microsoft.ProjectServer.Client.EngagementStatus StatusEx { get; set; }

        public override Microsoft.SharePoint.Client.User SubmittedBy => SubmittedByEx;
        public Microsoft.SharePoint.Client.User SubmittedByEx { get; set; }

        public override System.DateTime SubmittedDate => SubmittedDateEx;
        public System.DateTime SubmittedDateEx { get; set; }

        public override System.Boolean TimephasedEditsOnly => TimephasedEditsOnlyEx;
        public System.Boolean TimephasedEditsOnlyEx { get; set; }

    }
}

