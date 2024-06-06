using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.Staff;

public class GetStaffRequest : PagingRequest
{
    public string? Search { get; set; }
    public StaffSortByOption SortBy { get; set; } = StaffSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StaffSortByOption
{
    Id
}
