using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.User;

public class GetUsersRequest : PagingRequest
{
    // public string? Search { get; set; }
    public UserSortByOption SortBy { get; set; } = UserSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    public RoleUserFilter Filter { get; set; } = RoleUserFilter.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserSortByOption
{
    Id,
    Role,
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RoleUserFilter
{
    None,
    Student,
    Staff
}