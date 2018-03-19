
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FileCollectionMock : FileCollection
    {


        public override Microsoft.SharePoint.Client.File GetByUrl(System.String @url)
        {
            return GetByUrlEx;
        }
        public Microsoft.SharePoint.Client.File GetByUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.File Add(Microsoft.SharePoint.Client.FileCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.File AddEx { get; set;}

        public override Microsoft.SharePoint.Client.File AddTemplateFile(System.String @urlOfFile, Microsoft.SharePoint.Client.TemplateFileType @templateFileType)
        {
            return AddTemplateFileEx;
        }
        public Microsoft.SharePoint.Client.File AddTemplateFileEx { get; set;}

    }
}

