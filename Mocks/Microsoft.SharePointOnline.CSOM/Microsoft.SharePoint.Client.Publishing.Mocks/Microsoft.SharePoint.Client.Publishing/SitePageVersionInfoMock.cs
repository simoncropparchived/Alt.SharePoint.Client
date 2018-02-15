
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SitePageVersionInfoMock
    {


        public override System.DateTime LastVersionCreated => LastVersionCreatedEx;
        public System.DateTime LastVersionCreatedEx { get; set; }

        public override System.String LastVersionCreatedBy => LastVersionCreatedByEx;
        public System.String LastVersionCreatedByEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

