
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FileVersionCollectionMock : FileVersionCollection
    {


        public override Microsoft.SharePoint.Client.FileVersion GetById(System.Int32 @versionid)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.FileVersion GetByIdEx { get; set;}

        public override void DeleteByID(System.Int32 @vid)
        {
        }

        public override void DeleteByLabel(System.String @versionlabel)
        {
        }

        public override void DeleteAll()
        {
        }

        public override void RestoreByLabel(System.String @versionlabel)
        {
        }

    }
}

