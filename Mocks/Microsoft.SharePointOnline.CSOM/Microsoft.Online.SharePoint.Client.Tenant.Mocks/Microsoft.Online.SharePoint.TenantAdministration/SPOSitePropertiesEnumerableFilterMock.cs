
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPOSitePropertiesEnumerableFilterMock : SPOSitePropertiesEnumerableFilter
    {


        public override System.String Filter => FilterEx;
        public System.String FilterEx { get; set; }

        public override System.Boolean IncludeDetail => IncludeDetailEx;
        public System.Boolean IncludeDetailEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.PersonalSiteFilter IncludePersonalSite => IncludePersonalSiteEx;
        public Microsoft.Online.SharePoint.TenantAdministration.PersonalSiteFilter IncludePersonalSiteEx { get; set; }

        public override System.String StartIndex => StartIndexEx;
        public System.String StartIndexEx { get; set; }

        public override System.String Template => TemplateEx;
        public System.String TemplateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

