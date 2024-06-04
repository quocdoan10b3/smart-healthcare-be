using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.Student;

public class GetStudentsRequest : PagingRequest
{
    public string? Search { get; set; }
    public StudentSortByOption SortBy { get; set; } = StudentSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    public ClassStudentFilter Filter { get; set; } = ClassStudentFilter.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StudentSortByOption
{
    Id,
    Class,
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ClassStudentFilter
{
    None,
    [EnumMember(Value = "6")]
    K6,
    [EnumMember(Value = "7")]
    K7,
    [EnumMember(Value = "8")]
    K8,
    [EnumMember(Value = "9")]
    K9,
}