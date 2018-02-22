
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class BasePermissionsMock : BasePermissions
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void Set(Microsoft.SharePoint.Client.PermissionKind @perm)
        {
        }

        public override void Clear(Microsoft.SharePoint.Client.PermissionKind @perm)
        {
        }

        public override void ClearAll()
        {
        }

        public override System.Boolean Has(Microsoft.SharePoint.Client.PermissionKind @perm)
        {
            return HasEx;
        }
        public System.Boolean HasEx { get; set;}

        public override System.Boolean Equals(System.Object @obj)
        {
            return EqualsEx;
        }
        public System.Boolean EqualsEx { get; set;}

        public override System.Int32 GetHashCode()
        {
            return GetHashCodeEx;
        }
        public System.Int32 GetHashCodeEx { get; set;}

        public override System.Boolean HasPermissions(System.UInt32 @high, System.UInt32 @low)
        {
            return HasPermissionsEx;
        }
        public System.Boolean HasPermissionsEx { get; set;}

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

