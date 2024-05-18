using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public class GetHealthInsurancesRequest : PagingRequest
{
    public string? Search { get; set; }
    public HealthInsuranceSortByOption SortBy { get; set; } = HealthInsuranceSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    public HealthInsuranceFilter Filter { get; set; } = HealthInsuranceFilter.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceSortByOption
{
    Id,
    InsuranceNumber,
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceFilter
{
    None,
    True,
    False
}