
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ViewCreationInformationMock : ViewCreationInformation
    {


        public override System.Int32 baseViewId => baseViewIdEx;
        public System.Int32 baseViewIdEx { get; set; }

        public override System.Boolean Paged => PagedEx;
        public System.Boolean PagedEx { get; set; }

        public override System.Boolean PersonalView => PersonalViewEx;
        public System.Boolean PersonalViewEx { get; set; }

        public override System.String Query => QueryEx;
        public System.String QueryEx { get; set; }

        public override System.UInt32 RowLimit => RowLimitEx;
        public System.UInt32 RowLimitEx { get; set; }

        public override System.Boolean SetAsDefaultView => SetAsDefaultViewEx;
        public System.Boolean SetAsDefaultViewEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String[] ViewFields => ViewFieldsEx;
        public System.String[] ViewFieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.ViewType ViewTypeKind => ViewTypeKindEx;
        public Microsoft.SharePoint.Client.ViewType ViewTypeKindEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

