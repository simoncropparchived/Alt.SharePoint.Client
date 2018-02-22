
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class CostRateCreationInformationMock : CostRateCreationInformation
    {


        public override System.Double CostPerUse => CostPerUseEx;
        public System.Double CostPerUseEx { get; set; }

        public override System.DateTime EffectiveDate => EffectiveDateEx;
        public System.DateTime EffectiveDateEx { get; set; }

        public override System.Double OvertimeRate => OvertimeRateEx;
        public System.Double OvertimeRateEx { get; set; }

        public override System.Double StandardRate => StandardRateEx;
        public System.Double StandardRateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

