
namespace Microsoft.SharePoint.Client.Utilities
{
    public class ThemingOptionsMock
    {


        public override System.Boolean hideDefaultThemes => hideDefaultThemesEx;
        public System.Boolean hideDefaultThemesEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.JsonTheme[] themePreviews => themePreviewsEx;
        public Microsoft.SharePoint.Client.Utilities.JsonTheme[] themePreviewsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

