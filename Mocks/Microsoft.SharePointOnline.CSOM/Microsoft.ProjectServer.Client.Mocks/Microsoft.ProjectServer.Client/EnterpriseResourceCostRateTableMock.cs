
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCostRateTableMock
    {


        public override Microsoft.ProjectServer.Client.EnterpriseResourceCostRateCollection CostRates => CostRatesEx;
        public Microsoft.ProjectServer.Client.EnterpriseResourceCostRateCollection CostRatesEx { get; set; }

        public override Microsoft.ProjectServer.Client.CostRateTableName Name => NameEx;
        public Microsoft.ProjectServer.Client.CostRateTableName NameEx { get; set; }

    }
}

