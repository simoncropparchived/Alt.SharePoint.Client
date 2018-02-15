
namespace Microsoft.SharePoint.Client
{
    public class ChangeUserMock
    {


        public override System.Boolean Activate => ActivateEx;
        public System.Boolean ActivateEx { get; set; }

        public override System.Int32 UserId => UserIdEx;
        public System.Int32 UserIdEx { get; set; }

    }
}

