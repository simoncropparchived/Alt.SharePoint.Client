
namespace Microsoft.SharePoint.Client
{
    public class AlertMock : Alert
    {


        public override Microsoft.SharePoint.Client.AlertFrequency AlertFrequency => AlertFrequencyEx;
        public Microsoft.SharePoint.Client.AlertFrequency AlertFrequencyEx { get; set; }

        public override System.String AlertTemplateName => AlertTemplateNameEx;
        public System.String AlertTemplateNameEx { get; set; }

        public override System.DateTime AlertTime => AlertTimeEx;
        public System.DateTime AlertTimeEx { get; set; }

        public override Microsoft.SharePoint.Client.AlertType AlertType => AlertTypeEx;
        public Microsoft.SharePoint.Client.AlertType AlertTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.PropertyValues AllProperties => AllPropertiesEx;
        public Microsoft.SharePoint.Client.PropertyValues AllPropertiesEx { get; set; }

        public override System.Boolean AlwaysNotify => AlwaysNotifyEx;
        public System.Boolean AlwaysNotifyEx { get; set; }

        public override Microsoft.SharePoint.Client.AlertDeliveryChannel DeliveryChannels => DeliveryChannelsEx;
        public Microsoft.SharePoint.Client.AlertDeliveryChannel DeliveryChannelsEx { get; set; }

        public override Microsoft.SharePoint.Client.AlertEventType EventType => EventTypeEx;
        public Microsoft.SharePoint.Client.AlertEventType EventTypeEx { get; set; }

        public override System.String Filter => FilterEx;
        public System.String FilterEx { get; set; }

        public override System.Guid ID => IDEx;
        public System.Guid IDEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem Item => ItemEx;
        public Microsoft.SharePoint.Client.ListItem ItemEx { get; set; }

        public override System.Int32 ItemID => ItemIDEx;
        public System.Int32 ItemIDEx { get; set; }

        public override Microsoft.SharePoint.Client.List List => ListEx;
        public Microsoft.SharePoint.Client.List ListEx { get; set; }

        public override System.Guid ListID => ListIDEx;
        public System.Guid ListIDEx { get; set; }

        public override System.String ListUrl => ListUrlEx;
        public System.String ListUrlEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> PropertiesEx { get; set; }

        public override Microsoft.SharePoint.Client.AlertStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.AlertStatus StatusEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.User User => UserEx;
        public Microsoft.SharePoint.Client.User UserEx { get; set; }

        public override System.Int32 UserId => UserIdEx;
        public System.Int32 UserIdEx { get; set; }

    }
}

