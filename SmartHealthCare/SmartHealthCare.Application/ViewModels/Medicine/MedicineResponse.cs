using AutoMapper;

namespace SmartHealthCare.Application.ViewModels.Medicine;

public class MedicineResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }
    public string Effect { get; set; } = null!;
    public DateTime ImportDate { get; set; }
    public DateTime ExpDate { get; set; }
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Medicine, MedicineResponse>();
    }
}