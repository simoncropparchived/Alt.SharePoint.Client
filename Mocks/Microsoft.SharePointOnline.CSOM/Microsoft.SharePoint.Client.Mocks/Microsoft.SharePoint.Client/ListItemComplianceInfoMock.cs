
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemComplianceInfoMock : ListItemComplianceInfo
    {


        public override System.String ComplianceTag => ComplianceTagEx;
        public System.String ComplianceTagEx { get; set; }

        public override System.Boolean TagPolicyEventBased => TagPolicyEventBasedEx;
        public System.Boolean TagPolicyEventBasedEx { get; set; }

        public override System.Boolean TagPolicyHold => TagPolicyHoldEx;
        public System.Boolean TagPolicyHoldEx { get; set; }

        public override System.Boolean TagPolicyRecord => TagPolicyRecordEx;
        public System.Boolean TagPolicyRecordEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

