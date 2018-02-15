
namespace Microsoft.Office.SharePoint.Tools
{
    public class NormalizeStringMock : NormalizeString
    {


        public override Microsoft.Office.SharePoint.Tools.StringNormalizeMode FromLOB => FromLOBEx;
        public Microsoft.Office.SharePoint.Tools.StringNormalizeMode FromLOBEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.StringNormalizeMode ToLOB => ToLOBEx;
        public Microsoft.Office.SharePoint.Tools.StringNormalizeMode ToLOBEx { get; set; }

    }
}

