
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCostRateCollectionMock : EnterpriseResourceCostRateCollection
    {


        public override Microsoft.ProjectServer.Client.EnterpriseResourceCostRate Add(Microsoft.ProjectServer.Client.CostRateCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.EnterpriseResourceCostRate AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.EnterpriseResourceCostRate @costRate)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

