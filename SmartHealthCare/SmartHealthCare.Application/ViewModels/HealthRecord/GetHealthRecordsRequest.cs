using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.HealthRecord;

public class GetHealthRecordsRequest : PagingRequest
{
    public string? Search { get; set; }
    public HealthRecordSortByOption SortBy { get; set; } = HealthRecordSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthRecordSortByOption
{
    Id,
    StudentId,
}