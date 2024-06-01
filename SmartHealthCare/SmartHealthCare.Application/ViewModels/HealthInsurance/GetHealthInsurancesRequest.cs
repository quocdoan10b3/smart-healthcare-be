using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public class GetHealthInsurancesRequest : PagingRequest
{
    public string? Search { get; set; }
    public HealthInsuranceSortByOption SortBy { get; set; } = HealthInsuranceSortByOption.Id;
    public List<int> TagIds { get; set; } = new();
    public bool IsHidden { get; set; }
    public HealthInsuranceFilter Filter { get; set; } = HealthInsuranceFilter.None;
    public HealthInsuranceFilterStatus FilterStatus { get; set; } = HealthInsuranceFilterStatus.None;
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceSortByOption
{
    Id,
    InsuranceNumber,
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceFilterStatus
{
    None,
    True,
    False
}
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HealthInsuranceFilter
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
}
