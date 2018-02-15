
namespace Microsoft.SharePoint.Client
{
    public class AuditMock
    {


        public override Microsoft.SharePoint.Client.AuditMaskType AuditFlags => AuditFlagsEx;
        public Microsoft.SharePoint.Client.AuditMaskType AuditFlagsEx { get; set; }

    }
}

