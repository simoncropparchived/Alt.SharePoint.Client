
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldRatingScaleQuestionAnswerMock : FieldRatingScaleQuestionAnswer
    {


        public override System.Int32 Answer => AnswerEx;
        public System.Int32 AnswerEx { get; set; }

        public override System.String Question => QuestionEx;
        public System.String QuestionEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}
