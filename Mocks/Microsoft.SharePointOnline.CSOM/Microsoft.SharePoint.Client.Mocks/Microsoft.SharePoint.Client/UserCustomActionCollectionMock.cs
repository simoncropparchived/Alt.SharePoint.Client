
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class UserCustomActionCollectionMock : UserCustomActionCollection
    {


        public override Microsoft.SharePoint.Client.UserCustomAction GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.UserCustomAction GetByIdEx { get; set;}

        public override void Clear()
        {
        }

        public override Microsoft.SharePoint.Client.UserCustomAction Add()
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.UserCustomAction AddEx { get; set;}

    }
}

