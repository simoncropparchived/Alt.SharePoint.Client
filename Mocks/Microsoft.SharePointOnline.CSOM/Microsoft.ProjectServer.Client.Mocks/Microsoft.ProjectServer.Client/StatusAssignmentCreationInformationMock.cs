
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StatusAssignmentCreationInformationMock : StatusAssignmentCreationInformation
    {


        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Guid ProjectId => ProjectIdEx;
        public System.Guid ProjectIdEx { get; set; }

        public override Microsoft.ProjectServer.Client.StatusTaskCreationInformation Task => TaskEx;
        public Microsoft.ProjectServer.Client.StatusTaskCreationInformation TaskEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

