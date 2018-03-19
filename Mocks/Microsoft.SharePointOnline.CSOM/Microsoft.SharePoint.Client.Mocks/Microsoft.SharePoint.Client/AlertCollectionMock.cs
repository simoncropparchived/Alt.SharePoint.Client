
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AlertCollectionMock : AlertCollection
    {


        public override Microsoft.SharePoint.Client.Alert GetById(System.Guid @idAlert)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Alert GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Contains(System.Guid @idAlert)
        {
            return ContainsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> ContainsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Add(Microsoft.SharePoint.Client.AlertCreationInformation @alertCreationInformation)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> AddEx { get; set;}

        public override void DeleteAlertAtIndex(System.Int32 @index)
        {
        }

        public override void DeleteAlert(System.Guid @idAlert)
        {
        }

    }
}

