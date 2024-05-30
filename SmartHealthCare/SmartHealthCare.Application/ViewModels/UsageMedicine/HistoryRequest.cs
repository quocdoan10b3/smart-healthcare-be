namespace SmartHealthCare.Application.ViewModels.UsageMedicine;

public class HistoryRequest : PagingRequest
{
    public string? Search { get; set; }
    public  HistoriesSortByOption SortBy{ get; set; } = HistoriesSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
public enum HistoriesSortByOption
{
    Id,
    Name,
}