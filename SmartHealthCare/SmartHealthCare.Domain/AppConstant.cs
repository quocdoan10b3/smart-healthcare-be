namespace SmartHealthCare.Domain;

public static class AppConstant
{
    public const int DefaultPageNumber = 1; 
    public const int DefaultPageSize = 10;
}
public static class StringLength
{
    public const int Name = 256;
    public const int Description = 2000;
    public const int Email = 256;
    public const int Phone = 32;
    public const int Url = 512;
    public const int Token = 512;
    public const int ConfigurationJson = 4000;
    public const int Role = 16;
}

public static class AppRole
{
    public const string Admin = "admin";
    public const string Student = "student";
    public const string Staff = "staff";
}
