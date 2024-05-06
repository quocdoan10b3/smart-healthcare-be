using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public class GetHealthInsurancesRequest : PagingRequest
{
    public string? Search { get; set; }
    public HealthInsuranceSortByOption SortBy { get; set; } = HealthInsuranceSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceSortByOption
{
    Id,
    InsuranceNumber,
}