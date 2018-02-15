
namespace Microsoft.BusinessData.Runtime
{
    public class SubscriptionMock : Subscription
    {


        public override System.String Hash => HashEx;
        public System.String HashEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.Object> ID => IDEx;
        public System.Collections.Generic.IDictionary<System.String,System.Object> IDEx { get; set; }

    }
}

