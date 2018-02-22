
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteItemEventPropertiesMock : SPRemoteItemEventProperties
    {


        public override System.String WebUrl => WebUrlEx;
        public System.String WebUrlEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.String ListTitle => ListTitleEx;
        public System.String ListTitleEx { get; set; }

        public override System.Int32 ListItemId => ListItemIdEx;
        public System.Int32 ListItemIdEx { get; set; }

        public override System.Boolean Versionless => VersionlessEx;
        public System.Boolean VersionlessEx { get; set; }

        public override System.String UserDisplayName => UserDisplayNameEx;
        public System.String UserDisplayNameEx { get; set; }

        public override System.String UserLoginName => UserLoginNameEx;
        public System.String UserLoginNameEx { get; set; }

        public override System.Boolean IsBackgroundSave => IsBackgroundSaveEx;
        public System.Boolean IsBackgroundSaveEx { get; set; }

        public override System.Int32 CurrentUserId => CurrentUserIdEx;
        public System.Int32 CurrentUserIdEx { get; set; }

        public override System.String BeforeUrl => BeforeUrlEx;
        public System.String BeforeUrlEx { get; set; }

        public override System.String AfterUrl => AfterUrlEx;
        public System.String AfterUrlEx { get; set; }

        public override System.Byte[] ExternalNotificationMessage => ExternalNotificationMessageEx;
        public System.Byte[] ExternalNotificationMessageEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String,System.Object> BeforeProperties => BeforePropertiesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> BeforePropertiesEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String,System.Object> AfterProperties => AfterPropertiesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> AfterPropertiesEx { get; set; }

    }
}

