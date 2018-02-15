
namespace Microsoft.SharePoint.Client
{
    public class PushNotificationSubscriberMock
    {


        public override System.String CustomArgs => CustomArgsEx;
        public System.String CustomArgsEx { get; set; }

        public override System.Guid DeviceAppInstanceId => DeviceAppInstanceIdEx;
        public System.Guid DeviceAppInstanceIdEx { get; set; }

        public override System.DateTime LastModifiedTimeStamp => LastModifiedTimeStampEx;
        public System.DateTime LastModifiedTimeStampEx { get; set; }

        public override System.DateTime RegistrationTimeStamp => RegistrationTimeStampEx;
        public System.DateTime RegistrationTimeStampEx { get; set; }

        public override System.String ServiceToken => ServiceTokenEx;
        public System.String ServiceTokenEx { get; set; }

        public override System.String SubscriberType => SubscriberTypeEx;
        public System.String SubscriberTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.User User => UserEx;
        public Microsoft.SharePoint.Client.User UserEx { get; set; }

    }
}

