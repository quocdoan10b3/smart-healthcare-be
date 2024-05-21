namespace SmartHealthCare.Application.Common.Configurations;

public class MinioSettings
{
    public string Endpoint { get; set; } = null!;
    public string AccessKey { get; set; } = null!;
    public string SecretKey { get; set; } = null!;
    public string BucketName { get; set; } = null!;
    public string BaseUrl { get; set; } = null!;
}