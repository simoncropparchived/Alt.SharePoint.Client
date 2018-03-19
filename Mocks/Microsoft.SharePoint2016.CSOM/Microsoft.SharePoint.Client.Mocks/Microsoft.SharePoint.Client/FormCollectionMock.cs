
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FormCollectionMock : FormCollection
    {


        public override Microsoft.SharePoint.Client.Form GetByPageType(Microsoft.SharePoint.Client.PageType @formType)
        {
            return GetByPageTypeEx;
        }
        public Microsoft.SharePoint.Client.Form GetByPageTypeEx { get; set;}

        public override Microsoft.SharePoint.Client.Form GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Form GetByIdEx { get; set;}

    }
}

