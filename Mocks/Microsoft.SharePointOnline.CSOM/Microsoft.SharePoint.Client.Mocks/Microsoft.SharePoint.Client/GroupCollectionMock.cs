
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class GroupCollectionMock : GroupCollection
    {


        public override Microsoft.SharePoint.Client.Group GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.Group GetByNameEx { get; set;}

        public override Microsoft.SharePoint.Client.Group GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Group GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Group Add(Microsoft.SharePoint.Client.GroupCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Group AddEx { get; set;}

        public override void RemoveByLoginName(System.String @loginName)
        {
        }

        public override void RemoveById(System.Int32 @id)
        {
        }

        public override void Remove(Microsoft.SharePoint.Client.Group @group)
        {
        }

    }
}

