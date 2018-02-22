
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class ExternalUserMock : ExternalUser
    {


        public override System.String AcceptedAs => AcceptedAsEx;
        public System.String AcceptedAsEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String InvitedAs => InvitedAsEx;
        public System.String InvitedAsEx { get; set; }

        public override System.String UniqueId => UniqueIdEx;
        public System.String UniqueIdEx { get; set; }

    }
}

