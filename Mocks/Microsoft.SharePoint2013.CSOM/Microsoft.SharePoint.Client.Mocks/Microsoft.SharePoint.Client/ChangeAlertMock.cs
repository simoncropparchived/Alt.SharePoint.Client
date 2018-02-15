
namespace Microsoft.SharePoint.Client
{
    public class ChangeAlertMock
    {


        public override System.Guid AlertId => AlertIdEx;
        public System.Guid AlertIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

