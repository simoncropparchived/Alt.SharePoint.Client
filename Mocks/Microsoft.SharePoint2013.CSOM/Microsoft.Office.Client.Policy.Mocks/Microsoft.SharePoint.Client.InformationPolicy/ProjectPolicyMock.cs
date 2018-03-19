
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.InformationPolicy
{
    public class ProjectPolicyMock : ProjectPolicy
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String EmailBody => EmailBodyEx;
        public System.String EmailBodyEx { get; set; }

        public override System.String EmailBodyWithTeamMailbox => EmailBodyWithTeamMailboxEx;
        public System.String EmailBodyWithTeamMailboxEx { get; set; }

        public override System.String EmailSubject => EmailSubjectEx;
        public System.String EmailSubjectEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override void SavePolicy()
        {
        }

    }
}

