using AutoMapper;

namespace SmartHealthCare.Application.ViewModels.ImportMedicine;

public class HistoryImportResponse
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public DateTime ImportDate { get; set; }
    public DateTime ExpDate { get; set; }
    public int UsedCount { get; set; }
    public int MedicineId { get; set; }
    public string MedicineName { get; set; }
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.MedicineImport, HistoryImportResponse>()
            .ForMember(dto => dto.MedicineName, opt => opt.MapFrom(im=> im.Medicine.Name));
    }
}