namespace SmartHealthCare.Application.ViewModels.Medicine;

public class HistoryImportRequest : PagingRequest
{
    public string? Search { get; set; }
    public  ImportMedicineSortByOption SortBy{ get; set; } = ImportMedicineSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
public enum ImportMedicineSortByOption
{
    Id,
    ImportDate,
}