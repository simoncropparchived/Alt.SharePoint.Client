
namespace Microsoft.SharePoint.Packaging
{
    public class AppDetailsMock : AppDetails
    {


        public override System.String EulaUrl => EulaUrlEx;
        public System.String EulaUrlEx { get; set; }

        public override System.String PrivacyUrl => PrivacyUrlEx;
        public System.String PrivacyUrlEx { get; set; }

        public override System.String Publisher => PublisherEx;
        public System.String PublisherEx { get; set; }

        public override System.String ShortDescription => ShortDescriptionEx;
        public System.String ShortDescriptionEx { get; set; }

        public override System.String SupportUrl => SupportUrlEx;
        public System.String SupportUrlEx { get; set; }

    }
}

