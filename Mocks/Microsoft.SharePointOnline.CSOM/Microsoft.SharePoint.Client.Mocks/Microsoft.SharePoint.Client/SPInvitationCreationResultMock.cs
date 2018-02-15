
namespace Microsoft.SharePoint.Client
{
    public class SPInvitationCreationResultMock
    {


        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.String InvitationLink => InvitationLinkEx;
        public System.String InvitationLinkEx { get; set; }

        public override System.Boolean Succeeded => SucceededEx;
        public System.Boolean SucceededEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

