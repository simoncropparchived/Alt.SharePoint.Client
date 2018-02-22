
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class PeopleManagerMock : PeopleManager
    {


        public override System.String EditProfileLink => EditProfileLinkEx;
        public System.String EditProfileLinkEx { get; set; }

        public override System.Boolean IsMyPeopleListPublic => IsMyPeopleListPublicEx;
        public System.Boolean IsMyPeopleListPublicEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetFollowedTags(System.Int32 @cTagsToFetch)
        {
            return GetFollowedTagsEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetFollowedTagsEx { get; set;}

        public override Microsoft.SharePoint.Client.UserProfiles.PersonProperties GetMyProperties()
        {
            return GetMyPropertiesEx;
        }
        public Microsoft.SharePoint.Client.UserProfiles.PersonProperties GetMyPropertiesEx { get; set;}

        public override Microsoft.SharePoint.Client.UserProfiles.PersonProperties GetPropertiesFor(System.String @accountName)
        {
            return GetPropertiesForEx;
        }
        public Microsoft.SharePoint.Client.UserProfiles.PersonProperties GetPropertiesForEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetUserProfilePropertyFor(System.String @accountName, System.String @propertyName)
        {
            return GetUserProfilePropertyForEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetUserProfilePropertyForEx { get; set;}

        public override System.Collections.Generic.IEnumerable<System.String> GetUserProfilePropertiesFor(Microsoft.SharePoint.Client.UserProfiles.UserProfilePropertiesForUser @propertiesForUser)
        {
            return GetUserProfilePropertiesForEx;
        }
        public System.Collections.Generic.IEnumerable<System.String> GetUserProfilePropertiesForEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetMySuggestions()
        {
            return GetMySuggestionsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetMySuggestionsEx { get; set;}

        public override void HideSuggestion(System.String @accountName)
        {
        }

        public override void Follow(System.String @accountName)
        {
        }

        public override void StopFollowing(System.String @accountName)
        {
        }

        public override void FollowTag(System.Guid @value)
        {
        }

        public override void StopFollowingTag(System.Guid @value)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> AmIFollowing(System.String @accountName)
        {
            return AmIFollowingEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> AmIFollowingEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetPeopleFollowedByMe()
        {
            return GetPeopleFollowedByMeEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetPeopleFollowedByMeEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetPeopleFollowedBy(System.String @accountName)
        {
            return GetPeopleFollowedByEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetPeopleFollowedByEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetMyFollowers()
        {
            return GetMyFollowersEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetMyFollowersEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetFollowersFor(System.String @accountName)
        {
            return GetFollowersForEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.UserProfiles.PersonProperties> GetFollowersForEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> AmIFollowedBy(System.String @accountName)
        {
            return AmIFollowedByEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> AmIFollowedByEx { get; set;}

        public override void SetSingleValueProfileProperty(System.String @accountName, System.String @propertyName, System.String @propertyValue)
        {
        }

        public override void SetMultiValuedProfileProperty(System.String @accountName, System.String @propertyName, System.Collections.Generic.IList<System.String> @propertyValues)
        {
        }

        public override void SetMyProfilePicture(System.IO.Stream @picture)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDocumentLibrary(System.String @accountName, System.Boolean @createSiteIfNotExists, Microsoft.SharePoint.Client.UserProfiles.PersonalSiteCreationPriority @siteCreationPriority)
        {
            return GetDefaultDocumentLibraryEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDocumentLibraryEx { get; set;}

    }
}

