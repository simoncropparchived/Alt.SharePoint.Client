
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class QueueJobCollectionMock : QueueJobCollection
    {


        public override Microsoft.ProjectServer.Client.QueueJob GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.QueueJob GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.QueueJob GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.QueueJob GetByGuidEx { get; set;}

    }
}

