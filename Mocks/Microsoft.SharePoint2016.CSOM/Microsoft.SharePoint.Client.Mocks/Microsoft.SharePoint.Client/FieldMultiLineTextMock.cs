
namespace Microsoft.SharePoint.Client
{
    public class FieldMultiLineTextMock
    {


        public override System.Boolean AllowHyperlink => AllowHyperlinkEx;
        public System.Boolean AllowHyperlinkEx { get; set; }

        public override System.Boolean AppendOnly => AppendOnlyEx;
        public System.Boolean AppendOnlyEx { get; set; }

        public override System.Int32 NumberOfLines => NumberOfLinesEx;
        public System.Int32 NumberOfLinesEx { get; set; }

        public override System.Boolean RestrictedMode => RestrictedModeEx;
        public System.Boolean RestrictedModeEx { get; set; }

        public override System.Boolean RichText => RichTextEx;
        public System.Boolean RichTextEx { get; set; }

        public override System.Boolean WikiLinking => WikiLinkingEx;
        public System.Boolean WikiLinkingEx { get; set; }

    }
}

