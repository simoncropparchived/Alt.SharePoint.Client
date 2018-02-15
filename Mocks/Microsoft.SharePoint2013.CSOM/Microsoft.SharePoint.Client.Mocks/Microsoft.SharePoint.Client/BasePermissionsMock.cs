
namespace Microsoft.SharePoint.Client
{
    public class BasePermissionsMock : BasePermissions
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

