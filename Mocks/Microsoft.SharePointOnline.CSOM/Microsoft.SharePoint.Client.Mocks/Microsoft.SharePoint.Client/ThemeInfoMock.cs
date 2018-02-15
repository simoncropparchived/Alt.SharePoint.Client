
namespace Microsoft.SharePoint.Client
{
    public class ThemeInfoMock : ThemeInfo
    {


        public override System.String AccessibleDescription => AccessibleDescriptionEx;
        public System.String AccessibleDescriptionEx { get; set; }

        public override System.String ThemeBackgroundImageUri => ThemeBackgroundImageUriEx;
        public System.String ThemeBackgroundImageUriEx { get; set; }

    }
}

