namespace SmartHealthCare.Application.ViewModels.Notification;

public record AddNotificationRequest(string Title, string Content, string Image, DateTime DateCreatAt,int StaffId);