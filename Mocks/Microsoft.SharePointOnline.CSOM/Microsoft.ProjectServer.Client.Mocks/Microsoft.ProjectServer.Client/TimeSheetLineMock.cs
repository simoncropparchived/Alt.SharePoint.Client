
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetLineMock : TimeSheetLine
    {


        public override Microsoft.ProjectServer.Client.PublishedAssignment Assignment => AssignmentEx;
        public Microsoft.ProjectServer.Client.PublishedAssignment AssignmentEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetLineClass LineClass => LineClassEx;
        public Microsoft.ProjectServer.Client.TimeSheetLineClass LineClassEx { get; set; }

        public override System.String ProjectName => ProjectNameEx;
        public System.String ProjectNameEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetLineStatus Status => StatusEx;
        public Microsoft.ProjectServer.Client.TimeSheetLineStatus StatusEx { get; set; }

        public override System.String TaskName => TaskNameEx;
        public System.String TaskNameEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheet TimeSheet => TimeSheetEx;
        public Microsoft.ProjectServer.Client.TimeSheet TimeSheetEx { get; set; }

        public override System.String TotalWork => TotalWorkEx;
        public System.String TotalWorkEx { get; set; }

        public override System.TimeSpan TotalWorkTimeSpan => TotalWorkTimeSpanEx;
        public System.TimeSpan TotalWorkTimeSpanEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetValidationType ValidationType => ValidationTypeEx;
        public Microsoft.ProjectServer.Client.TimeSheetValidationType ValidationTypeEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetWorkCollection Work => WorkEx;
        public Microsoft.ProjectServer.Client.TimeSheetWorkCollection WorkEx { get; set; }

        public override void DeleteObject()
        {
        }

        public override void Submit(System.String @comment)
        {
        }

    }
}

