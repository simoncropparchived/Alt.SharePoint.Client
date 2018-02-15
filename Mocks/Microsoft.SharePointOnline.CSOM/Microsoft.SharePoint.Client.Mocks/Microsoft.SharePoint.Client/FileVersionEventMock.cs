
namespace Microsoft.SharePoint.Client
{
    public class FileVersionEventMock
    {


        public override System.String Editor => EditorEx;
        public System.String EditorEx { get; set; }

        public override System.String EditorEmail => EditorEmailEx;
        public System.String EditorEmailEx { get; set; }

        public override Microsoft.SharePoint.Client.SharedWithUser SharedByUser => SharedByUserEx;
        public Microsoft.SharePoint.Client.SharedWithUser SharedByUserEx { get; set; }

        public override Microsoft.SharePoint.Client.SharedWithUserCollection SharedWithUsers => SharedWithUsersEx;
        public Microsoft.SharePoint.Client.SharedWithUserCollection SharedWithUsersEx { get; set; }

        public override System.DateTime Time => TimeEx;
        public System.DateTime TimeEx { get; set; }

        public override Microsoft.SharePoint.Client.FileVersionEventType EventType => EventTypeEx;
        public Microsoft.SharePoint.Client.FileVersionEventType EventTypeEx { get; set; }

    }
}

