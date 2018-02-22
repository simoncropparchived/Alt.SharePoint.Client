
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RemoteWebMock : RemoteWeb
    {


        public override System.Boolean CanSendEmail => CanSendEmailEx;
        public System.Boolean CanSendEmailEx { get; set; }

        public override System.Boolean ShareByEmailEnabled => ShareByEmailEnabledEx;
        public System.Boolean ShareByEmailEnabledEx { get; set; }

        public override System.Boolean ShareByLinkEnabled => ShareByLinkEnabledEx;
        public System.Boolean ShareByLinkEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.File GetFileByServerRelativeUrl(System.String @serverRelativeFileUrl)
        {
            return GetFileByServerRelativeUrlEx;
        }
        public Microsoft.SharePoint.Client.File GetFileByServerRelativeUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.List GetListById(System.Guid @listGuid)
        {
            return GetListByIdEx;
        }
        public Microsoft.SharePoint.Client.List GetListByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.List GetListByServerRelativeUrl(System.String @serverRelativeUrl)
        {
            return GetListByServerRelativeUrlEx;
        }
        public Microsoft.SharePoint.Client.List GetListByServerRelativeUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.Folder GetFolderByServerRelativeUrl(System.String @serverRelativeUrl)
        {
            return GetFolderByServerRelativeUrlEx;
        }
        public Microsoft.SharePoint.Client.Folder GetFolderByServerRelativeUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.Group GetGroupById(System.Int32 @groupId)
        {
            return GetGroupByIdEx;
        }
        public Microsoft.SharePoint.Client.Group GetGroupByIdEx { get; set;}

    }
}

