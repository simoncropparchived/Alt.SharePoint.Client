
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.TranslationServices
{
    public class SyncTranslatorMock : SyncTranslator
    {


        public override Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehavior => OutputSaveBehaviorEx;
        public Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehaviorEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> Translate(System.String @inputFile, System.String @outputFile)
        {
            return TranslateEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.Office.Client.TranslationServices.TranslationItemInfo> TranslateEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> TranslateStream(System.IO.Stream @inputFile, System.String @fileExtension)
        {
            return TranslateStreamEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> TranslateStreamEx { get; set;}

    }
}

