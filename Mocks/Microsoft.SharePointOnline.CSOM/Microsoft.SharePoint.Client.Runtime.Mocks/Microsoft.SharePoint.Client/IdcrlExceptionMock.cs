
namespace Microsoft.SharePoint.Client
{
    public class IdcrlExceptionMock : IdcrlException
    {


        public override System.Int32 ErrorCode => ErrorCodeEx;
        public System.Int32 ErrorCodeEx { get; set; }

    }
}

