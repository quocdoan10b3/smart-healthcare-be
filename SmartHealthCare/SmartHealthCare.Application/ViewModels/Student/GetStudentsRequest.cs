using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.Student;

public class GetStudentsRequest : PagingRequest
{
    public string? Search { get; set; }
    public StudentSortByOption SortBy { get; set; } = StudentSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    // public ClassStudentFilter Filter { get; set; } = ClassStudentFilter.None;
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
    A6,
    A7,
    A8,
    A9
}