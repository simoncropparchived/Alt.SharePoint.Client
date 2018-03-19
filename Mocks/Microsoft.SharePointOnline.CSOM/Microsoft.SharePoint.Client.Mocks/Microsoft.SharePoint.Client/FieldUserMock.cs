
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldUserMock : FieldUser
    {


        public override System.Boolean AllowDisplay => AllowDisplayEx;
        public System.Boolean AllowDisplayEx { get; set; }

        public override System.Boolean Presence => PresenceEx;
        public System.Boolean PresenceEx { get; set; }

        public override System.Int32 SelectionGroup => SelectionGroupEx;
        public System.Int32 SelectionGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldUserSelectionMode SelectionMode => SelectionModeEx;
        public Microsoft.SharePoint.Client.FieldUserSelectionMode SelectionModeEx { get; set; }

    }
}

