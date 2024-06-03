using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.FeedBack;

public class GetFeedBackRequest : PagingRequest
{
    public string? Search { get; set; }
    public FeedBackSortByOption SortBy { get; set; } = FeedBackSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    // public FeedBackFilter Filter { get; set; } = FeedBackFilter.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FeedBackSortByOption
{
    Id,
    CommentDate,
    Rating,
}
// [JsonConverter(typeof(JsonStringEnumConverter))]
// public enum FeedBackFilter
// {
//     None,
//     True,
//     False
// }