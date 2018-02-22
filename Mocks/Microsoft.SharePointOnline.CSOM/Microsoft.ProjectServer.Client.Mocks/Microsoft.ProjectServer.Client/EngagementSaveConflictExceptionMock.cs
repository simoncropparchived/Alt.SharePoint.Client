
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EngagementSaveConflictExceptionMock : EngagementSaveConflictException
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

