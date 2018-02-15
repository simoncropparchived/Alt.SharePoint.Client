
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class PeopleManagerMock
    {


        public override System.String EditProfileLink => EditProfileLinkEx;
        public System.String EditProfileLinkEx { get; set; }

        public override System.Boolean IsMyPeopleListPublic => IsMyPeopleListPublicEx;
        public System.Boolean IsMyPeopleListPublicEx { get; set; }

    }
}

