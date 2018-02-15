
namespace Microsoft.SharePoint.Client.Publishing
{
    public class TextValueWithLanguageMock : TextValueWithLanguage
    {


        public override System.String ColorSeed => ColorSeedEx;
        public System.String ColorSeedEx { get; set; }

        public override System.Int32 Lcid => LcidEx;
        public System.Int32 LcidEx { get; set; }

        public override System.String Text => TextEx;
        public System.String TextEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

