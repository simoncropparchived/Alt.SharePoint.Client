
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectEngagementCreationInformationMock : ProjectEngagementCreationInformation
    {


        public override Microsoft.ProjectServer.Client.EnterpriseResource Resource => ResourceEx;
        public Microsoft.ProjectServer.Client.EnterpriseResource ResourceEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

