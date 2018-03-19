
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PublishedTaskCollectionMock : PublishedTaskCollection
    {


        public override Microsoft.ProjectServer.Client.PublishedTask GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PublishedTask GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PublishedTask GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PublishedTask GetByGuidEx { get; set;}

    }
}

