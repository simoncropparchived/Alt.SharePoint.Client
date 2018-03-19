
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class PushNotificationSubscriberCollectionMock : PushNotificationSubscriberCollection
    {


        public override Microsoft.SharePoint.Client.PushNotificationSubscriber GetByStoreId(System.String @id)
        {
            return GetByStoreIdEx;
        }
        public Microsoft.SharePoint.Client.PushNotificationSubscriber GetByStoreIdEx { get; set;}

    }
}

