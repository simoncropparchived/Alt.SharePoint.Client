
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class AddinSettingsMock : AddinSettings
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean Enabled => EnabledEx;
        public System.Boolean EnabledEx { get; set; }

        public override System.String HeadScript => HeadScriptEx;
        public System.String HeadScriptEx { get; set; }

        public override System.String HtmlEndBody => HtmlEndBodyEx;
        public System.String HtmlEndBodyEx { get; set; }

        public override System.String HtmlStartBody => HtmlStartBodyEx;
        public System.String HtmlStartBodyEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> MetaTagPagePropertyMappings => MetaTagPagePropertyMappingsEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> MetaTagPagePropertyMappingsEx { get; set; }

        public override System.String Namespace => NamespaceEx;
        public System.String NamespaceEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

    }
}

