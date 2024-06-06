using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.Notification;

public class GetNotificationRequest : PagingRequest
{
    public string? Search { get; set; }
    public  NotificationSortByOption SortBy{ get; set; } = NotificationSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NotificationSortByOption
{
    Id
}