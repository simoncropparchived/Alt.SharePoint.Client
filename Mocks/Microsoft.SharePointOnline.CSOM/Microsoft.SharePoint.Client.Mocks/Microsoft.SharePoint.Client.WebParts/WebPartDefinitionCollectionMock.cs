
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WebParts
{
    public class WebPartDefinitionCollectionMock : WebPartDefinitionCollection
    {


        public override Microsoft.SharePoint.Client.WebParts.WebPartDefinition GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.WebParts.WebPartDefinition GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.WebParts.WebPartDefinition GetByControlId(System.String @controlId)
        {
            return GetByControlIdEx;
        }
        public Microsoft.SharePoint.Client.WebParts.WebPartDefinition GetByControlIdEx { get; set;}

    }
}

