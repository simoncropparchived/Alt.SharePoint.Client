
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TimeSheetLineCreationInformationMock : TimeSheetLineCreationInformation
    {


        public override System.Guid AssignmentId => AssignmentIdEx;
        public System.Guid AssignmentIdEx { get; set; }

        public override System.String Comment => CommentEx;
        public System.String CommentEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.ProjectServer.Client.TimeSheetLineClass LineClass => LineClassEx;
        public Microsoft.ProjectServer.Client.TimeSheetLineClass LineClassEx { get; set; }

        public override System.Guid ProjectId => ProjectIdEx;
        public System.Guid ProjectIdEx { get; set; }

        public override System.String TaskName => TaskNameEx;
        public System.String TaskNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

