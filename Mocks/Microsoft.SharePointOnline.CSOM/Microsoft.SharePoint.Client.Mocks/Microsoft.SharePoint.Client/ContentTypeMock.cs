
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ContentTypeMock : ContentType
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource DescriptionResource => DescriptionResourceEx;
        public Microsoft.SharePoint.Client.UserResource DescriptionResourceEx { get; set; }

        public override System.String DisplayFormTemplateName => DisplayFormTemplateNameEx;
        public System.String DisplayFormTemplateNameEx { get; set; }

        public override System.String DisplayFormUrl => DisplayFormUrlEx;
        public System.String DisplayFormUrlEx { get; set; }

        public override System.String DocumentTemplate => DocumentTemplateEx;
        public System.String DocumentTemplateEx { get; set; }

        public override System.String DocumentTemplateUrl => DocumentTemplateUrlEx;
        public System.String DocumentTemplateUrlEx { get; set; }

        public override System.String EditFormTemplateName => EditFormTemplateNameEx;
        public System.String EditFormTemplateNameEx { get; set; }

        public override System.String EditFormUrl => EditFormUrlEx;
        public System.String EditFormUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldLinkCollection FieldLinks => FieldLinksEx;
        public Microsoft.SharePoint.Client.FieldLinkCollection FieldLinksEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldCollection Fields => FieldsEx;
        public Microsoft.SharePoint.Client.FieldCollection FieldsEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentTypeId Id => IdEx;
        public Microsoft.SharePoint.Client.ContentTypeId IdEx { get; set; }

        public override System.String JSLink => JSLinkEx;
        public System.String JSLinkEx { get; set; }

        public override System.String MobileDisplayFormUrl => MobileDisplayFormUrlEx;
        public System.String MobileDisplayFormUrlEx { get; set; }

        public override System.String MobileEditFormUrl => MobileEditFormUrlEx;
        public System.String MobileEditFormUrlEx { get; set; }

        public override System.String MobileNewFormUrl => MobileNewFormUrlEx;
        public System.String MobileNewFormUrlEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource NameResource => NameResourceEx;
        public Microsoft.SharePoint.Client.UserResource NameResourceEx { get; set; }

        public override System.String NewFormTemplateName => NewFormTemplateNameEx;
        public System.String NewFormTemplateNameEx { get; set; }

        public override System.String NewFormUrl => NewFormUrlEx;
        public System.String NewFormUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentType Parent => ParentEx;
        public Microsoft.SharePoint.Client.ContentType ParentEx { get; set; }

        public override System.Boolean ReadOnly => ReadOnlyEx;
        public System.Boolean ReadOnlyEx { get; set; }

        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

        public override System.String SchemaXmlWithResourceTokens => SchemaXmlWithResourceTokensEx;
        public System.String SchemaXmlWithResourceTokensEx { get; set; }

        public override System.String Scope => ScopeEx;
        public System.String ScopeEx { get; set; }

        public override System.Boolean Sealed => SealedEx;
        public System.Boolean SealedEx { get; set; }

        public override System.String StringId => StringIdEx;
        public System.String StringIdEx { get; set; }

        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociations => WorkflowAssociationsEx;
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociationsEx { get; set; }

        public override void Update(System.Boolean @updateChildren)
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

