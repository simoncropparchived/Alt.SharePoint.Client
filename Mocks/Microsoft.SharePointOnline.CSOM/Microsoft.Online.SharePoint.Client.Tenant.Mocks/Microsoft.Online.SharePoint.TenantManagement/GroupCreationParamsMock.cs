
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class GroupCreationParamsMock : GroupCreationParams
    {


        public override System.String Classification => ClassificationEx;
        public System.String ClassificationEx { get; set; }

        public override System.String[] CreationOptions => CreationOptionsEx;
        public System.String[] CreationOptionsEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String[] Owners => OwnersEx;
        public System.String[] OwnersEx { get; set; }

    }
}

