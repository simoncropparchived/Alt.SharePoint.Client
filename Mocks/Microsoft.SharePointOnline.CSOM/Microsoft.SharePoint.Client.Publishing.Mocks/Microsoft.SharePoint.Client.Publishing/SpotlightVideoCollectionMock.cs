
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SpotlightVideoCollectionMock : SpotlightVideoCollection
    {


        public override Microsoft.SharePoint.Client.Publishing.SpotlightVideo GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Publishing.SpotlightVideo GetByIdEx { get; set;}

    }
}

