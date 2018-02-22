
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.DocumentManagement
{
    public class MetadataDefaultsMock : MetadataDefaults
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetFieldDefault(Microsoft.SharePoint.Client.Folder @folder, System.String @fieldName, System.String @value)
        {
            return SetFieldDefaultEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> SetFieldDefaultEx { get; set;}

        public override void Update()
        {
        }

    }
}

