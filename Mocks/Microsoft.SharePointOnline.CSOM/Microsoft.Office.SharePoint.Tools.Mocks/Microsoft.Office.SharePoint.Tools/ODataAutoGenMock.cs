
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class ODataAutoGenMock : ODataAutoGen
    {


        public override Microsoft.Office.SharePoint.Tools.Model GenerateExternalContentTypes(System.String @lsiName, System.Collections.Generic.IEnumerable<System.String> @entitiesToGenerate)
        {
            return GenerateExternalContentTypesEx;
        }
        public Microsoft.Office.SharePoint.Tools.Model GenerateExternalContentTypesEx { get; set;}

        public override void CreateAssociation(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @sourceEntity, System.String @destinationEntity)
        {
        }

        public override void AddSystemFilter(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, Microsoft.Office.SharePoint.Tools.SystemFilterType @systemFilter)
        {
        }

        public override void RemoveSystemFilter(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, Microsoft.Office.SharePoint.Tools.SystemFilterType @systemFilter)
        {
        }

        public override void AddUserFilter(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, Microsoft.Office.SharePoint.Tools.UserFilterType @filterType, System.String @columnName, System.String @defaultValue)
        {
        }

        public override void RemoveUserFilter(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, Microsoft.Office.SharePoint.Tools.UserFilterType @filterType, System.String @columnName)
        {
        }

        public override void AddColumn(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, System.String @columnName)
        {
        }

        public override void RemoveColumn(Microsoft.Office.SharePoint.Tools.Model @bdcModel, System.String @entityName, System.String @columnName)
        {
        }

    }
}

