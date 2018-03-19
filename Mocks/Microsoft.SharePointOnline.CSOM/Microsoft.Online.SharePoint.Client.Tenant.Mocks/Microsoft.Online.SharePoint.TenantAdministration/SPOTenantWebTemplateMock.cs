
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SPOTenantWebTemplateMock : SPOTenantWebTemplate
    {


        public override System.Int32 CompatibilityLevel => CompatibilityLevelEx;
        public System.Int32 CompatibilityLevelEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String DisplayCategory => DisplayCategoryEx;
        public System.String DisplayCategoryEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.UInt32 Lcid => LcidEx;
        public System.UInt32 LcidEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

