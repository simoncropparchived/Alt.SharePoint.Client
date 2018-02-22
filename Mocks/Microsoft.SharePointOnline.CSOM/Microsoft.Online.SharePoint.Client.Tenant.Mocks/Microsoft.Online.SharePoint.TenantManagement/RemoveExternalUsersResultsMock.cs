
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class RemoveExternalUsersResultsMock : RemoveExternalUsersResults
    {


        public override System.String[] RemoveFailed => RemoveFailedEx;
        public System.String[] RemoveFailedEx { get; set; }

        public override System.String[] RemoveSucceeded => RemoveSucceededEx;
        public System.String[] RemoveSucceededEx { get; set; }

    }
}

