
namespace Microsoft.SharePoint.Client
{
    public class CustomActionElementMock : CustomActionElement
    {


        public override System.Guid ClientSideComponentId => ClientSideComponentIdEx;
        public System.Guid ClientSideComponentIdEx { get; set; }

        public override System.String ClientSideComponentProperties => ClientSideComponentPropertiesEx;
        public System.String ClientSideComponentPropertiesEx { get; set; }

        public override System.String CommandUIExtension => CommandUIExtensionEx;
        public System.String CommandUIExtensionEx { get; set; }

        public override System.String EnabledScript => EnabledScriptEx;
        public System.String EnabledScriptEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override System.String Location => LocationEx;
        public System.String LocationEx { get; set; }

        public override System.String RegistrationId => RegistrationIdEx;
        public System.String RegistrationIdEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionRegistrationType RegistrationType => RegistrationTypeEx;
        public Microsoft.SharePoint.Client.UserCustomActionRegistrationType RegistrationTypeEx { get; set; }

        public override System.Boolean RequireSiteAdministrator => RequireSiteAdministratorEx;
        public System.Boolean RequireSiteAdministratorEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions Rights => RightsEx;
        public Microsoft.SharePoint.Client.BasePermissions RightsEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String UrlAction => UrlActionEx;
        public System.String UrlActionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

