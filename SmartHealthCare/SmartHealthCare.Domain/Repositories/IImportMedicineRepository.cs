using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IImportMedicineRepository: IRepositoryBase<MedicineImport>
{
    public IQueryable<MedicineImport> Search(string? search);
}