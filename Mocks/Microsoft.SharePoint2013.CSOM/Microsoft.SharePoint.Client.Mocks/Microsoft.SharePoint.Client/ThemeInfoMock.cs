
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ThemeInfoMock : ThemeInfo
    {


        public override System.String AccessibleDescription => AccessibleDescriptionEx;
        public System.String AccessibleDescriptionEx { get; set; }

        public override System.String ThemeBackgroundImageUri => ThemeBackgroundImageUriEx;
        public System.String ThemeBackgroundImageUriEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetThemeShadeByName(System.String @name)
        {
            return GetThemeShadeByNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetThemeShadeByNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetThemeFontByName(System.String @name, System.UInt32 @lcid)
        {
            return GetThemeFontByNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetThemeFontByNameEx { get; set;}

    }
}

