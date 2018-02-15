
namespace Microsoft.SharePoint.ApplicationPages.ClientPickerQuery
{
    public class PickerEntityInformationRequestMock : PickerEntityInformationRequest
    {


        public override System.String EmailAddress => EmailAddressEx;
        public System.String EmailAddressEx { get; set; }

        public override System.Int32 GroupId => GroupIdEx;
        public System.Int32 GroupIdEx { get; set; }

        public override System.String Key => KeyEx;
        public System.String KeyEx { get; set; }

        public override Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalType => PrincipalTypeEx;
        public Microsoft.SharePoint.Client.Utilities.PrincipalType PrincipalTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

