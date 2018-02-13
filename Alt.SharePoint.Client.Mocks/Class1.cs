using System;
using Microsoft.SharePoint.Client;

namespace Alt.SharePoint.Client.Mocks
{
    public class MockListItem : ListItem
    {
        string displayName;

        public override string DisplayName => displayName;

        public void SetDisplayName(string s)
        {
            displayName = s;
        }
    }
    public class Class2: ClientContext
    {
        public override void ExecuteQuery()
        {
            //base.ExecuteQuery();
        }
    }
}
