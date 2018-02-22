
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FileMock : File
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override Microsoft.SharePoint.Client.User CheckedOutByUser => CheckedOutByUserEx;
        public Microsoft.SharePoint.Client.User CheckedOutByUserEx { get; set; }

        public override System.String CheckInComment => CheckInCommentEx;
        public System.String CheckInCommentEx { get; set; }

        public override Microsoft.SharePoint.Client.CheckOutType CheckOutType => CheckOutTypeEx;
        public Microsoft.SharePoint.Client.CheckOutType CheckOutTypeEx { get; set; }

        public override System.String ContentTag => ContentTagEx;
        public System.String ContentTagEx { get; set; }

        public override Microsoft.SharePoint.Client.CustomizedPageStatus CustomizedPageStatus => CustomizedPageStatusEx;
        public Microsoft.SharePoint.Client.CustomizedPageStatus CustomizedPageStatusEx { get; set; }

        public override System.String ETag => ETagEx;
        public System.String ETagEx { get; set; }

        public override System.Boolean Exists => ExistsEx;
        public System.Boolean ExistsEx { get; set; }

        public override System.Int64 Length => LengthEx;
        public System.Int64 LengthEx { get; set; }

        public override Microsoft.SharePoint.Client.FileLevel Level => LevelEx;
        public Microsoft.SharePoint.Client.FileLevel LevelEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem ListItemAllFields => ListItemAllFieldsEx;
        public Microsoft.SharePoint.Client.ListItem ListItemAllFieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.User LockedByUser => LockedByUserEx;
        public Microsoft.SharePoint.Client.User LockedByUserEx { get; set; }

        public override System.Int32 MajorVersion => MajorVersionEx;
        public System.Int32 MajorVersionEx { get; set; }

        public override System.Int32 MinorVersion => MinorVersionEx;
        public System.Int32 MinorVersionEx { get; set; }

        public override Microsoft.SharePoint.Client.User ModifiedBy => ModifiedByEx;
        public Microsoft.SharePoint.Client.User ModifiedByEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.DateTime TimeCreated => TimeCreatedEx;
        public System.DateTime TimeCreatedEx { get; set; }

        public override System.DateTime TimeLastModified => TimeLastModifiedEx;
        public System.DateTime TimeLastModifiedEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Int32 UIVersion => UIVersionEx;
        public System.Int32 UIVersionEx { get; set; }

        public override System.String UIVersionLabel => UIVersionLabelEx;
        public System.String UIVersionLabelEx { get; set; }

        public override Microsoft.SharePoint.Client.FileVersionCollection Versions => VersionsEx;
        public Microsoft.SharePoint.Client.FileVersionCollection VersionsEx { get; set; }

        public override void UndoCheckOut()
        {
        }

        public override void CheckIn(System.String @comment, Microsoft.SharePoint.Client.CheckinType @checkInType)
        {
        }

        public override void Publish(System.String @comment)
        {
        }

        public override void UnPublish(System.String @comment)
        {
        }

        public override void Approve(System.String @comment)
        {
        }

        public override void Deny(System.String @comment)
        {
        }

        public override Microsoft.SharePoint.Client.WebParts.LimitedWebPartManager GetLimitedWebPartManager(Microsoft.SharePoint.Client.WebParts.PersonalizationScope @scope)
        {
            return GetLimitedWebPartManagerEx;
        }
        public Microsoft.SharePoint.Client.WebParts.LimitedWebPartManager GetLimitedWebPartManagerEx { get; set;}

        public override void MoveTo(System.String @newUrl, Microsoft.SharePoint.Client.MoveOperations @flags)
        {
        }

        public override void CopyTo(System.String @strNewUrl, System.Boolean @bOverWrite)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> OpenBinaryStream()
        {
            return OpenBinaryStreamEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> OpenBinaryStreamEx { get; set;}

        public override void SaveBinary(Microsoft.SharePoint.Client.FileSaveBinaryInformation @parameters)
        {
        }

        public override void DeleteObject()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Recycle()
        {
            return RecycleEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleEx { get; set;}

        public override void CheckOut()
        {
        }

    }
}

