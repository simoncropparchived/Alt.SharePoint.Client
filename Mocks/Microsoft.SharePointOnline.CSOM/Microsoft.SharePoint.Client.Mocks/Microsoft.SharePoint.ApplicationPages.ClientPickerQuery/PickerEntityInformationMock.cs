
namespace Microsoft.SharePoint.ApplicationPages.ClientPickerQuery
{
    public class PickerEntityInformationMock
    {


        public override Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.PickerEntityInformationRequest Entity => EntityEx;
        public Microsoft.SharePoint.ApplicationPages.ClientPickerQuery.PickerEntityInformationRequest EntityEx { get; set; }

        public override System.Int32 TotalMemberCount => TotalMemberCountEx;
        public System.Int32 TotalMemberCountEx { get; set; }

    }
}

