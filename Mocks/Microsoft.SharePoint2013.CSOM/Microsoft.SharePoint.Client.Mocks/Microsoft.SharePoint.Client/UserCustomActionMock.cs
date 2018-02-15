
namespace Microsoft.SharePoint.Client
{
    public class UserCustomActionMock : UserCustomAction
    {


        public override System.String CommandUIExtension => CommandUIExtensionEx;
        public System.String CommandUIExtensionEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override System.String Location => LocationEx;
        public System.String LocationEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String RegistrationId => RegistrationIdEx;
        public System.String RegistrationIdEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionRegistrationType RegistrationType => RegistrationTypeEx;
        public Microsoft.SharePoint.Client.UserCustomActionRegistrationType RegistrationTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions Rights => RightsEx;
        public Microsoft.SharePoint.Client.BasePermissions RightsEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionScope Scope => ScopeEx;
        public Microsoft.SharePoint.Client.UserCustomActionScope ScopeEx { get; set; }

        public override System.String ScriptBlock => ScriptBlockEx;
        public System.String ScriptBlockEx { get; set; }

        public override System.String ScriptSrc => ScriptSrcEx;
        public System.String ScriptSrcEx { get; set; }

        public override System.Int32 Sequence => SequenceEx;
        public System.Int32 SequenceEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String VersionOfUserCustomAction => VersionOfUserCustomActionEx;
        public System.String VersionOfUserCustomActionEx { get; set; }

    }
}

