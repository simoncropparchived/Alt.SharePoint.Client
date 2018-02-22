
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SpotlightChannelCollectionMock : SpotlightChannelCollection
    {


        public override Microsoft.SharePoint.Client.Publishing.SpotlightChannel GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Publishing.SpotlightChannel GetByIdEx { get; set;}

    }
}

