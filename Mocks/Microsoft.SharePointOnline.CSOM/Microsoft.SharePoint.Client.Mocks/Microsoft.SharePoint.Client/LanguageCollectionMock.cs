
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class LanguageCollectionMock : LanguageCollection
    {


        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Language> GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Language> GetByIdEx { get; set;}

    }
}

