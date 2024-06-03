using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class ImportMedicineRepository: RepositoryBase<MedicineImport>, IImportMedicineRepository
{
    public IQueryable<MedicineImport> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Medicine.Name) && b.Medicine.Name.Contains(search)));

    public ImportMedicineRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}