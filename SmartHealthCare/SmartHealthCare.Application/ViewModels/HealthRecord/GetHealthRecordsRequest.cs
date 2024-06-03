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
    [EnumMember(Value = "2024-2025")]
    N2024_2025,
    [EnumMember(Value = "2025-2026")]
    N2025_2026,
    [EnumMember(Value = "2026-2027")]
    N2026_2027,
    [EnumMember(Value = "2027-2028")]
    N2027_2028,
    [EnumMember(Value = "2028-2029")]
    N2028_2029,
    [EnumMember(Value = "2029-2030")]
    N2029_2030
}