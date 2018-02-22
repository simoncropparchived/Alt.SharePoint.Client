
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class MicroServiceManagerMock : MicroServiceManager
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> AddMicroserviceWorkItem(System.Byte[] @payLoad, System.Int32 @minutes, Microsoft.SharePoint.Client.MicroServiceWorkItemProperties @properties)
        {
            return AddMicroserviceWorkItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> AddMicroserviceWorkItemEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMicroserviceWorkItem(System.Guid @workItemId)
        {
            return DeleteMicroserviceWorkItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMicroserviceWorkItemEx { get; set;}

    }
}

