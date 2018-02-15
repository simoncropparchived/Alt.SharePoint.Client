
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCostRateMock
    {


        public override System.Double CostPerUse => CostPerUseEx;
        public System.Double CostPerUseEx { get; set; }

        public override System.DateTime EffectiveStarting => EffectiveStartingEx;
        public System.DateTime EffectiveStartingEx { get; set; }

        public override System.DateTime EffectiveUntil => EffectiveUntilEx;
        public System.DateTime EffectiveUntilEx { get; set; }

        public override System.Double OvertimeRate => OvertimeRateEx;
        public System.Double OvertimeRateEx { get; set; }

        public override System.Double StandardRate => StandardRateEx;
        public System.Double StandardRateEx { get; set; }

    }
}

