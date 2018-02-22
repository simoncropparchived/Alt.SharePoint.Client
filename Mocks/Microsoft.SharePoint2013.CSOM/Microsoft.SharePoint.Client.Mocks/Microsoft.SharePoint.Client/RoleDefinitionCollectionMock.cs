
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RoleDefinitionCollectionMock : RoleDefinitionCollection
    {


        public override Microsoft.SharePoint.Client.RoleDefinition GetByName(System.String @name)
        {
            return GetByNameEx;
        }
        public Microsoft.SharePoint.Client.RoleDefinition GetByNameEx { get; set;}

        public override Microsoft.SharePoint.Client.RoleDefinition Add(Microsoft.SharePoint.Client.RoleDefinitionCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.RoleDefinition AddEx { get; set;}

        public override Microsoft.SharePoint.Client.RoleDefinition GetById(System.Int32 @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.RoleDefinition GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.RoleDefinition GetByType(Microsoft.SharePoint.Client.RoleType @roleType)
        {
            return GetByTypeEx;
        }
        public Microsoft.SharePoint.Client.RoleDefinition GetByTypeEx { get; set;}

    }
}

