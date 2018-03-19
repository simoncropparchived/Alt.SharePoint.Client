
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EnterpriseResourceCreationInformationMock : EnterpriseResourceCreationInformation
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsBudget => IsBudgetEx;
        public System.Boolean IsBudgetEx { get; set; }

        public override System.Boolean IsGeneric => IsGenericEx;
        public System.Boolean IsGenericEx { get; set; }

        public override System.Boolean IsInactive => IsInactiveEx;
        public System.Boolean IsInactiveEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.EnterpriseResourceType ResourceType => ResourceTypeEx;
        public Microsoft.ProjectServer.Client.EnterpriseResourceType ResourceTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

