
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AuditMock : Audit
    {


        public override Microsoft.SharePoint.Client.AuditMaskType AuditFlags => AuditFlagsEx;
        public Microsoft.SharePoint.Client.AuditMaskType AuditFlagsEx { get; set; }

        public override void Update()
        {
        }

    }
}

