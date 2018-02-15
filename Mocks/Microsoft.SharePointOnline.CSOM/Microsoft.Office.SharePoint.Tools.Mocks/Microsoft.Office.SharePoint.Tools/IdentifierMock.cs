
namespace Microsoft.Office.SharePoint.Tools
{
    public class IdentifierMock : Identifier
    {


        public override Microsoft.Office.SharePoint.Tools.IdentifierType TypeName => TypeNameEx;
        public Microsoft.Office.SharePoint.Tools.IdentifierType TypeNameEx { get; set; }

    }
}

