
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class WebCollectionMock : WebCollection
    {


        public override Microsoft.SharePoint.Client.Web Add(Microsoft.SharePoint.Client.WebCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Web AddEx { get; set;}

    }
}

