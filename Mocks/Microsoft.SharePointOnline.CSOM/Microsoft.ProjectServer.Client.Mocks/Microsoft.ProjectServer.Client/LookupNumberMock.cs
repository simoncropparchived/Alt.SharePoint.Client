
namespace Microsoft.ProjectServer.Client
{
    public class LookupNumberMock : LookupNumber
    {


        public override System.Decimal Value => ValueEx;
        public System.Decimal ValueEx { get; set; }

    }
}

