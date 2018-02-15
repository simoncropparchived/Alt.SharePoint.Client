
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class ThemePropertiesMock : ThemeProperties
    {


        public override System.Boolean IsInverted => IsInvertedEx;
        public System.Boolean IsInvertedEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> Palette => PaletteEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> PaletteEx { get; set; }

    }
}

