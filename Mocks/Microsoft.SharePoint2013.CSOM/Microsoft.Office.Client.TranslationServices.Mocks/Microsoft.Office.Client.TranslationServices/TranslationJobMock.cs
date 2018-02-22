
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationJobMock : TranslationJob
    {


        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehavior => OutputSaveBehaviorEx;
        public Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehaviorEx { get; set; }

        public override void AddFile(System.String @inputFile, System.String @outputFile)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddFolder(Microsoft.SharePoint.Client.Folder @inputFolder, Microsoft.SharePoint.Client.Folder @outputFolder, System.Boolean @recursion)
        {
            return AddFolderEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddFolderEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddLibrary(Microsoft.SharePoint.Client.List @inputList, Microsoft.SharePoint.Client.List @outputList)
        {
            return AddLibraryEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> AddLibraryEx { get; set;}

        public override void Start()
        {
        }

    }
}

