
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class CopyMigrationOptionsMock : CopyMigrationOptions
    {


        public override System.Boolean AllowSchemaMismatch => AllowSchemaMismatchEx;
        public System.Boolean AllowSchemaMismatchEx { get; set; }

        public override System.Boolean IgnoreVersionHistory => IgnoreVersionHistoryEx;
        public System.Boolean IgnoreVersionHistoryEx { get; set; }

        public override System.Boolean IsMoveMode => IsMoveModeEx;
        public System.Boolean IsMoveModeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

