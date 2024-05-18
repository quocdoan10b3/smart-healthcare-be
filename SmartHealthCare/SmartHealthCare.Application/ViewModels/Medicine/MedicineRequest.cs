namespace SmartHealthCare.Application.ViewModels.Medicine;

public class MedicineRequest : PagingRequest
{
    public string? Search { get; set; }
    public  MedicinesSortByOption SortBy{ get; set; } = MedicinesSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
public enum MedicinesSortByOption
{
    Id,
    Name,
}