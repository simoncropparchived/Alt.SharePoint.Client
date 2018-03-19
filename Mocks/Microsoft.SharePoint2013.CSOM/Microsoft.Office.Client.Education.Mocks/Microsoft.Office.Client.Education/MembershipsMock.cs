
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class MembershipsMock : Memberships
    {


        public override Microsoft.Office.Client.Education.Membership AddEntity(Microsoft.Office.Client.Education.Membership @entity)
        {
            return AddEntityEx;
        }
        public Microsoft.Office.Client.Education.Membership AddEntityEx { get; set;}

    }
}

