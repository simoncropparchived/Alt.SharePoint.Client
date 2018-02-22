
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SubtitleFileMock : SubtitleFile
    {


        public override System.String Language => LanguageEx;
        public System.String LanguageEx { get; set; }

        public override System.String NativeLanguageName => NativeLanguageNameEx;
        public System.String NativeLanguageNameEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

    }
}

