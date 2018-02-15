
namespace Microsoft.Office.SharePoint.Tools
{
    public class MetadataObjectMock
    {


        public override Microsoft.Office.SharePoint.Tools.LocalizedDisplayName[] LocalizedDisplayNames => LocalizedDisplayNamesEx;
        public Microsoft.Office.SharePoint.Tools.LocalizedDisplayName[] LocalizedDisplayNamesEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.Property[] Properties => PropertiesEx;
        public Microsoft.Office.SharePoint.Tools.Property[] PropertiesEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String DefaultDisplayName => DefaultDisplayNameEx;
        public System.String DefaultDisplayNameEx { get; set; }

        public override System.Boolean IsCached => IsCachedEx;
        public System.Boolean IsCachedEx { get; set; }

    }
}

