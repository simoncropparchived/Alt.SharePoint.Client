
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StageDetailPageCreationInformationMock : StageDetailPageCreationInformation
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Int32 Position => PositionEx;
        public System.Int32 PositionEx { get; set; }

        public override System.Boolean RequiresAttention => RequiresAttentionEx;
        public System.Boolean RequiresAttentionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

