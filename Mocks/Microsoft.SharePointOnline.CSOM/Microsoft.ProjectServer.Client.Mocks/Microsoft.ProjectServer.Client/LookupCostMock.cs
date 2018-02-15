
namespace Microsoft.ProjectServer.Client
{
    public class LookupCostMock : LookupCost
    {


        public override System.Decimal Value => ValueEx;
        public System.Decimal ValueEx { get; set; }

    }
}

