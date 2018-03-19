
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPContainerIdMock : SPContainerId
    {


        public override Microsoft.SharePoint.Client.CompliancePolicy.SPContainerType ContainerType => ContainerTypeEx;
        public Microsoft.SharePoint.Client.CompliancePolicy.SPContainerType ContainerTypeEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.String SiteUrl => SiteUrlEx;
        public System.String SiteUrlEx { get; set; }

        public override System.Guid TenantId => TenantIdEx;
        public System.Guid TenantIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Int32 Version => VersionEx;
        public System.Int32 VersionEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> Serialize()
        {
            return SerializeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> SerializeEx { get; set;}

    }
}

