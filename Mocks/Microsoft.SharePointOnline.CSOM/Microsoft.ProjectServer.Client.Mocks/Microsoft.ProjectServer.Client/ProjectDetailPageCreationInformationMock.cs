
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectDetailPageCreationInformationMock : ProjectDetailPageCreationInformation
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsCreate => IsCreateEx;
        public System.Boolean IsCreateEx { get; set; }

        public override System.Int32 Position => PositionEx;
        public System.Int32 PositionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

