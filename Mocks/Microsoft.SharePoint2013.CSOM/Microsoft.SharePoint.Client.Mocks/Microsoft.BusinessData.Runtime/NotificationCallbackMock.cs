
namespace Microsoft.BusinessData.Runtime
{
    public class NotificationCallbackMock
    {


        public override System.String NotificationContext => NotificationContextEx;
        public System.String NotificationContextEx { get; set; }

        public override System.String NotificationEndpoint => NotificationEndpointEx;
        public System.String NotificationEndpointEx { get; set; }

        public override System.String NotificationForwarderType => NotificationForwarderTypeEx;
        public System.String NotificationForwarderTypeEx { get; set; }

    }
}

