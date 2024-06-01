using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.HealthRecord;

public class GetHealthRecordsRequest : PagingRequest
{
    public string? Search { get; set; }
    public HealthRecordSortByOption SortBy { get; set; } = HealthRecordSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    public HealthRecordFilter Filter { get; set; } = HealthRecordFilter.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthRecordSortByOption
{
    Id,
    StudentId,
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthRecordFilter
{
    None,
    [EnumMember(Value = "2020-2021")]
    N2020_2021,
    [EnumMember(Value = "2021-2022")]
    N2021_2022,
    [EnumMember(Value = "2022-2023")]
    N2022_2023,
    [EnumMember(Value = "2023-2024")]
    N2023_2024,
}