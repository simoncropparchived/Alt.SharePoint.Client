
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemVersionCollectionMock : ListItemVersionCollection
    {


        public override Microsoft.SharePoint.Client.ListItemVersion GetById(System.Int32 @versionId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.ListItemVersion GetByIdEx { get; set;}

    }
}

