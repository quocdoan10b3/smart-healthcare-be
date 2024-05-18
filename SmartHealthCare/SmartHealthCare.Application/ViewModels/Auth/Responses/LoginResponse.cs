using AutoMapper;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Application.ViewModels.Auth.Responses;

public record LoginResponse(string AccessToken, string RefreshToken, UserResponse User, string Role);

public record UserResponse(string Id, string UserName, string Email, string FullName, string AvatarUrl)
{
	public UserResponse() : this("", "", "", "",""){}
}

public class MapperProfile : Profile
{
	public MapperProfile()
	{
		CreateMap<Domain.Entities.User, UserResponse>();
	}
}