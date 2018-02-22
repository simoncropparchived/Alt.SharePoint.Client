
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPScsTenantEndPointInfoMock : SPScsTenantEndPointInfo
    {


        public override System.String FarmLabel => FarmLabelEx;
        public System.String FarmLabelEx { get; set; }

        public override System.String ScsEndPointUrl => ScsEndPointUrlEx;
        public System.String ScsEndPointUrlEx { get; set; }

        public override System.String SearchFarmId => SearchFarmIdEx;
        public System.String SearchFarmIdEx { get; set; }

    }
}

