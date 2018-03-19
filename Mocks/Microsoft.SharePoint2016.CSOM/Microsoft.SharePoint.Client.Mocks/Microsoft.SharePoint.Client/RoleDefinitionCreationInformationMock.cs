
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RoleDefinitionCreationInformationMock : RoleDefinitionCreationInformation
    {


        public override Microsoft.SharePoint.Client.BasePermissions BasePermissions => BasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions BasePermissionsEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

