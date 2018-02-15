
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class ExternalUserMock
    {


        public override System.String AcceptedAs => AcceptedAsEx;
        public System.String AcceptedAsEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String InvitedAs => InvitedAsEx;
        public System.String InvitedAsEx { get; set; }

        public override System.String InvitedBy => InvitedByEx;
        public System.String InvitedByEx { get; set; }

        public override System.String UniqueId => UniqueIdEx;
        public System.String UniqueIdEx { get; set; }

        public override System.Int32 UserId => UserIdEx;
        public System.Int32 UserIdEx { get; set; }

        public override System.DateTime WhenCreated => WhenCreatedEx;
        public System.DateTime WhenCreatedEx { get; set; }

    }
}

