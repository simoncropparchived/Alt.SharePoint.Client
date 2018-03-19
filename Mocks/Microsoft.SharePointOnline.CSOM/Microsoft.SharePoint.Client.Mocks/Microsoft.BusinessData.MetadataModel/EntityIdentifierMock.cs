
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityIdentifierMock : EntityIdentifier
    {


        public override System.String IdentifierType => IdentifierTypeEx;
        public System.String IdentifierTypeEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDisplayName()
        {
            return GetDefaultDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDisplayNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> ContainsLocalizedDisplayName()
        {
            return ContainsLocalizedDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> ContainsLocalizedDisplayNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetLocalizedDisplayName()
        {
            return GetLocalizedDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetLocalizedDisplayNameEx { get; set;}

    }
}

