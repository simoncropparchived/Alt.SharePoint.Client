
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

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override Microsoft.SharePoint.Client.EffectiveInformationRightsManagementSettings EffectiveInformationRightsManagementSettings => EffectiveInformationRightsManagementSettingsEx;
        public Microsoft.SharePoint.Client.EffectiveInformationRightsManagementSettings EffectiveInformationRightsManagementSettingsEx { get; set; }

        public override System.String ETag => ETagEx;
        public System.String ETagEx { get; set; }

        public override System.Boolean Exists => ExistsEx;
        public System.Boolean ExistsEx { get; set; }

        public override Microsoft.SharePoint.Client.InformationRightsManagementFileSettings InformationRightsManagementSettings => InformationRightsManagementSettingsEx;
        public Microsoft.SharePoint.Client.InformationRightsManagementFileSettings InformationRightsManagementSettingsEx { get; set; }

        public override System.Boolean IrmEnabled => IrmEnabledEx;
        public System.Boolean IrmEnabledEx { get; set; }

        public override System.Int64 Length => LengthEx;
        public System.Int64 LengthEx { get; set; }

        public override Microsoft.SharePoint.Client.FileLevel Level => LevelEx;
        public Microsoft.SharePoint.Client.FileLevel LevelEx { get; set; }

        public override System.String LinkingUri => LinkingUriEx;
        public System.String LinkingUriEx { get; set; }

        public override System.String LinkingUrl => LinkingUrlEx;
        public System.String LinkingUrlEx { get; set; }

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

        public override Microsoft.SharePoint.Client.ListPageRenderType PageRenderType => PageRenderTypeEx;
        public Microsoft.SharePoint.Client.ListPageRenderType PageRenderTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.PropertyValues Properties => PropertiesEx;
        public Microsoft.SharePoint.Client.PropertyValues PropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ServerRelativePath => ServerRelativePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ServerRelativePathEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

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

        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override Microsoft.SharePoint.Client.FileVersionEventCollection VersionEvents => VersionEventsEx;
        public Microsoft.SharePoint.Client.FileVersionEventCollection VersionEventsEx { get; set; }

        public override Microsoft.SharePoint.Client.FileVersionCollection Versions => VersionsEx;
        public Microsoft.SharePoint.Client.FileVersionCollection VersionsEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override Microsoft.SharePoint.Client.WebParts.LimitedWebPartManager GetLimitedWebPartManager(Microsoft.SharePoint.Client.WebParts.PersonalizationScope @scope)
        {
            return GetLimitedWebPartManagerEx;
        }
        public Microsoft.SharePoint.Client.WebParts.LimitedWebPartManager GetLimitedWebPartManagerEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetPreAuthorizedAccessUrl(System.Int32 @expirationHours)
        {
            return GetPreAuthorizedAccessUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetPreAuthorizedAccessUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetImagePreviewUrl(System.Int32 @width, System.Int32 @height, System.String @clientType)
        {
            return GetImagePreviewUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetImagePreviewUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetImagePreviewUri(System.Int32 @width, System.Int32 @height, System.String @clientType)
        {
            return GetImagePreviewUriEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetImagePreviewUriEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int64> StartUpload(System.Guid @uploadId, System.IO.Stream @stream)
        {
            return StartUploadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int64> StartUploadEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int64> ContinueUpload(System.Guid @uploadId, System.Int64 @fileOffset, System.IO.Stream @stream)
        {
            return ContinueUploadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int64> ContinueUploadEx { get; set;}

        public override Microsoft.SharePoint.Client.File FinishUpload(System.Guid @uploadId, System.Int64 @fileOffset, System.IO.Stream @stream)
        {
            return FinishUploadEx;
        }
        public Microsoft.SharePoint.Client.File FinishUploadEx { get; set;}

        public override void CancelUpload(System.Guid @uploadId)
        {
        }

        public override Microsoft.SharePoint.Client.Utilities.UploadStatus GetUploadStatus(System.Guid @uploadId)
        {
            return GetUploadStatusEx;
        }
        public Microsoft.SharePoint.Client.Utilities.UploadStatus GetUploadStatusEx { get; set;}

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

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleWithETag(System.String @etagMatch)
        {
            return RecycleWithETagEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleWithETagEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> ExecuteCobaltRequest(System.IO.Stream @inputStream)
        {
            return ExecuteCobaltRequestEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> ExecuteCobaltRequestEx { get; set;}

        public override void CheckOut()
        {
        }

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

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetWOPIFrameUrl(Microsoft.SharePoint.Client.Utilities.SPWOPIFrameAction @action)
        {
            return GetWOPIFrameUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetWOPIFrameUrlEx { get; set;}

        public override void Update()
        {
        }

        public override void MoveTo(System.String @newUrl, Microsoft.SharePoint.Client.MoveOperations @flags)
        {
        }

        public override void MoveToUsingPath(Microsoft.SharePoint.Client.ResourcePath @newPath, Microsoft.SharePoint.Client.MoveOperations @moveOperations)
        {
        }

        public override void CopyTo(System.String @strNewUrl, System.Boolean @bOverWrite)
        {
        }

        public override void CopyToUsingPath(Microsoft.SharePoint.Client.ResourcePath @newPath, System.Boolean @bOverWrite)
        {
        }

    }
}

