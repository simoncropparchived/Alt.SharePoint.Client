
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PublishedAssignmentCollectionMock : PublishedAssignmentCollection
    {


        public override Microsoft.ProjectServer.Client.PublishedAssignment GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PublishedAssignment GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedAssignment GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PublishedAssignment GetByGuidEx { get; set;}

    }
}

