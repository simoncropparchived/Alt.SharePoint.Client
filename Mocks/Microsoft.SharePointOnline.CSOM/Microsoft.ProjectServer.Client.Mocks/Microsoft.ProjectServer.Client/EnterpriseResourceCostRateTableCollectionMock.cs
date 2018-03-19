
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCostRateTableCollectionMock : EnterpriseResourceCostRateTableCollection
    {


        public override Microsoft.ProjectServer.Client.EnterpriseResourceCostRateTable GetByName(Microsoft.ProjectServer.Client.CostRateTableName @name)
        {
            return GetByNameEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResourceCostRateTable GetByNameEx { get; set;}

    }
}

