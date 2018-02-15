
namespace Microsoft.SharePoint.Client
{
    public class FileVersionMock
    {


        public override System.String CheckInComment => CheckInCommentEx;
        public System.String CheckInCommentEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override Microsoft.SharePoint.Client.User CreatedBy => CreatedByEx;
        public Microsoft.SharePoint.Client.User CreatedByEx { get; set; }

        public override System.Int32 ID => IDEx;
        public System.Int32 IDEx { get; set; }

        public override System.Boolean IsCurrentVersion => IsCurrentVersionEx;
        public System.Boolean IsCurrentVersionEx { get; set; }

        public override System.Int64 Length => LengthEx;
        public System.Int64 LengthEx { get; set; }

        public override System.Int32 Size => SizeEx;
        public System.Int32 SizeEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String VersionLabel => VersionLabelEx;
        public System.String VersionLabelEx { get; set; }

    }
}

