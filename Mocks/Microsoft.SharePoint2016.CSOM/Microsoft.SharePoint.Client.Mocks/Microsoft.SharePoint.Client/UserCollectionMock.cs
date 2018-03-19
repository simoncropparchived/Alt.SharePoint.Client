
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class UserCollectionMock : UserCollection
    {


        public override Microsoft.SharePoint.Client.User GetByLoginName(System.String @loginName)
        {
            return GetByLoginNameEx;
        }
        public Microsoft.SharePoint.Client.User GetByLoginNameEx { get; set;}

        public override Microsoft.SharePoint.Client.User GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.User GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.User GetByEmail(System.String @emailAddress)
        {
            return GetByEmailEx;
        }
        public Microsoft.SharePoint.Client.User GetByEmailEx { get; set;}

        public override void RemoveByLoginName(System.String @loginName)
        {
        }

        public override void RemoveById(System.Int32 @id)
        {
        }

        public override void Remove(Microsoft.SharePoint.Client.User @user)
        {
        }

        public override Microsoft.SharePoint.Client.User Add(Microsoft.SharePoint.Client.UserCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.User AddEx { get; set;}

        public override Microsoft.SharePoint.Client.User AddUser(Microsoft.SharePoint.Client.User @user)
        {
            return AddUserEx;
        }
        public Microsoft.SharePoint.Client.User AddUserEx { get; set;}

    }
}

