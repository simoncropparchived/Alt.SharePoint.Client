
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.WebControls
{
    public class ControlMessageMock : ControlMessage
    {


        public override System.Int32 code => codeEx;
        public System.Int32 codeEx { get; set; }

        public override System.String correlationID => correlationIDEx;
        public System.String correlationIDEx { get; set; }

        public override System.Boolean encodeDetails => encodeDetailsEx;
        public System.Boolean encodeDetailsEx { get; set; }

        public override System.String header => headerEx;
        public System.String headerEx { get; set; }

        public override Microsoft.Office.Server.Search.WebControls.MessageLevel level => levelEx;
        public Microsoft.Office.Server.Search.WebControls.MessageLevel levelEx { get; set; }

        public override System.String messageDetails => messageDetailsEx;
        public System.String messageDetailsEx { get; set; }

        public override System.String messageDetailsForViewers => messageDetailsForViewersEx;
        public System.String messageDetailsForViewersEx { get; set; }

        public override System.String serverTypeId => serverTypeIdEx;
        public System.String serverTypeIdEx { get; set; }

        public override System.Boolean showForViewerUsers => showForViewerUsersEx;
        public System.Boolean showForViewerUsersEx { get; set; }

        public override System.Boolean showInEditModeOnly => showInEditModeOnlyEx;
        public System.Boolean showInEditModeOnlyEx { get; set; }

        public override System.String stackTrace => stackTraceEx;
        public System.String stackTraceEx { get; set; }

        public override System.String type => typeEx;
        public System.String typeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

