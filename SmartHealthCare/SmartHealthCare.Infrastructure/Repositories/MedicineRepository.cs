using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;
using MedicineResponse = SmartHealthCare.Domain.Repositories.MedicineResponse;

namespace SmartHealthCare.Infrastructure.Repositories;

public class MedicineRepository : RepositoryBase<Medicine>, IMedicineRepository
{
    public IQueryable<Medicine> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Name) && b.Name.Contains(search)));
    public async Task<IQueryable<MedicineResponse>> GetAggregatedMedicinesAsync(string? search)
    {
        var query = Search(search);

        var result =query.Include(m=> m.MedicineImports)
            
            .Select(g => new MedicineResponse
            {
                Id = g.Id,
                Name = g.Name,
                Quantity = g.MedicineImports.Where(mi=> mi.ExpDate.Date >= DateTime.Today.Date)
                    .Sum(mi=> mi.Quantity - mi.UsedCount),
                Effect = g.Effect,
                ImageMedicine = g.ImageMedicine
            });

        return result;
    }
    public MedicineRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}