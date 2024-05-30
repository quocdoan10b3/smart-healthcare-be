using AutoMapper;

namespace SmartHealthCare.Application.ViewModels.Prescription;

public class PrescriptionResponse
{
    public int HistoryId { get; set; }
    public int MedicineId { get; set; }
    public string NameMedicine { get; set; } = null!;
    public int Quantity { get; set; }
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Prescription, PrescriptionResponse >()
            .ForMember(dto => dto.NameMedicine, opt => opt.MapFrom(p=> p.Medicine.Name));
    }
}
