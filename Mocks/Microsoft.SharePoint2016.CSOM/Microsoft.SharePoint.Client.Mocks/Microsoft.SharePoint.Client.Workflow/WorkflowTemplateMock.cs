
namespace Microsoft.SharePoint.Client.Workflow
{
    public class WorkflowTemplateMock
    {


        public override System.Boolean AllowManual => AllowManualEx;
        public System.Boolean AllowManualEx { get; set; }

        public override System.String AssociationUrl => AssociationUrlEx;
        public System.String AssociationUrlEx { get; set; }

        public override System.Boolean AutoStartChange => AutoStartChangeEx;
        public System.Boolean AutoStartChangeEx { get; set; }

        public override System.Boolean AutoStartCreate => AutoStartCreateEx;
        public System.Boolean AutoStartCreateEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsDeclarative => IsDeclarativeEx;
        public System.Boolean IsDeclarativeEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions PermissionsManual => PermissionsManualEx;
        public Microsoft.SharePoint.Client.BasePermissions PermissionsManualEx { get; set; }

    }
}

