namespace SmartHealthCare.Application.ViewModels.Statistics;

public class GetStatisticsRequest
{
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
}