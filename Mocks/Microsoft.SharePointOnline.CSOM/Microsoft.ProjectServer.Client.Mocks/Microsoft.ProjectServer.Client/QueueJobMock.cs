
namespace Microsoft.ProjectServer.Client
{
    public class QueueJobMock
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.ProjectServer.Client.JobState JobState => JobStateEx;
        public Microsoft.ProjectServer.Client.JobState JobStateEx { get; set; }

        public override Microsoft.ProjectServer.Client.QueueMsgType MessageType => MessageTypeEx;
        public Microsoft.ProjectServer.Client.QueueMsgType MessageTypeEx { get; set; }

        public override System.Int32 PercentComplete => PercentCompleteEx;
        public System.Int32 PercentCompleteEx { get; set; }

        public override Microsoft.ProjectServer.Client.Project Project => ProjectEx;
        public Microsoft.ProjectServer.Client.Project ProjectEx { get; set; }

        public override Microsoft.SharePoint.Client.User Submitter => SubmitterEx;
        public Microsoft.SharePoint.Client.User SubmitterEx { get; set; }

        public override System.TimeSpan WaitTime => WaitTimeEx;
        public System.TimeSpan WaitTimeEx { get; set; }

    }
}

