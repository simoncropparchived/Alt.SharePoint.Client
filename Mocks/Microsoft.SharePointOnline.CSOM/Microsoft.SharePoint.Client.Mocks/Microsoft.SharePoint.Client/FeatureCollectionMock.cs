
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FeatureCollectionMock : FeatureCollection
    {


        public override Microsoft.SharePoint.Client.Feature GetById(System.Guid @featureId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Feature GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Feature Add(System.Guid @featureId, System.Boolean @force, Microsoft.SharePoint.Client.FeatureDefinitionScope @featdefScope)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Feature AddEx { get; set;}

        public override void Remove(System.Guid @featureId, System.Boolean @force)
        {
        }

    }
}

