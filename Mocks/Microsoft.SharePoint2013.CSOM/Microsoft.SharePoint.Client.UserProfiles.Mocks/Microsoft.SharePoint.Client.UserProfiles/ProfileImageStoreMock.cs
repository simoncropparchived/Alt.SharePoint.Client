
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class ProfileImageStoreMock : ProfileImageStore
    {


        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> SaveUploadedFile(System.Int32 @profileType, System.String @fileNamePrefix, System.Boolean @isFeedAttachment, System.String @clientFilePath, System.Int32 @fileSize, System.IO.Stream @fileStream)
        {
            return SaveUploadedFileEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> SaveUploadedFileEx { get; set;}

    }
}

