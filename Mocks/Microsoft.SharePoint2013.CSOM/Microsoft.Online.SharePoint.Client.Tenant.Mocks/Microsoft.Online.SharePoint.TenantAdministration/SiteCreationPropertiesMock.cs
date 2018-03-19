
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SiteCreationPropertiesMock : SiteCreationProperties
    {


        public override System.Int32 CompatibilityLevel => CompatibilityLevelEx;
        public System.Int32 CompatibilityLevelEx { get; set; }

        public override System.UInt32 Lcid => LcidEx;
        public System.UInt32 LcidEx { get; set; }

        public override System.String Owner => OwnerEx;
        public System.String OwnerEx { get; set; }

        public override System.Int64 StorageMaximumLevel => StorageMaximumLevelEx;
        public System.Int64 StorageMaximumLevelEx { get; set; }

        public override System.Int64 StorageWarningLevel => StorageWarningLevelEx;
        public System.Int64 StorageWarningLevelEx { get; set; }

        public override System.String Template => TemplateEx;
        public System.String TemplateEx { get; set; }

        public override System.Int32 TimeZoneId => TimeZoneIdEx;
        public System.Int32 TimeZoneIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Double UserCodeMaximumLevel => UserCodeMaximumLevelEx;
        public System.Double UserCodeMaximumLevelEx { get; set; }

        public override System.Double UserCodeWarningLevel => UserCodeWarningLevelEx;
        public System.Double UserCodeWarningLevelEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

