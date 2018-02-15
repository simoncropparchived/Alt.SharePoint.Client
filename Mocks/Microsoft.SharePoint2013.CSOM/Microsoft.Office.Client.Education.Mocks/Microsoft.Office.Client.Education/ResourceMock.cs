
namespace Microsoft.Office.Client.Education
{
    public class ResourceMock
    {


        public override Microsoft.Office.Client.Education.Event Event => EventEx;
        public Microsoft.Office.Client.Education.Event EventEx { get; set; }

        public override System.String FolderUrl => FolderUrlEx;
        public System.String FolderUrlEx { get; set; }

        public override System.Boolean IsVisibleToStudent => IsVisibleToStudentEx;
        public System.Boolean IsVisibleToStudentEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

        public override Microsoft.Office.Client.Education.LearningEntity Parent => ParentEx;
        public Microsoft.Office.Client.Education.LearningEntity ParentEx { get; set; }

        public override System.String ResourceCategory => ResourceCategoryEx;
        public System.String ResourceCategoryEx { get; set; }

        public override System.String ResourceType => ResourceTypeEx;
        public System.String ResourceTypeEx { get; set; }

    }
}

