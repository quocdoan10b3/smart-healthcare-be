using AutoMapper;
using SmartHealthCare.Domain.Repositories;

namespace SmartHealthCare.Application.ViewModels.Medicine;


public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Medicine, MedicineResponse>();
    }
}