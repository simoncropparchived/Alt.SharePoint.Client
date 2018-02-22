
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ViewCollectionMock : ViewCollection
    {


        public override Microsoft.SharePoint.Client.View GetByTitle(System.String @strTitle)
        {
            return GetByTitleEx;
        }
        public Microsoft.SharePoint.Client.View GetByTitleEx { get; set;}

        public override Microsoft.SharePoint.Client.View GetById(System.Guid @guidId)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.View GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.View Add(Microsoft.SharePoint.Client.ViewCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.View AddEx { get; set;}

    }
}

