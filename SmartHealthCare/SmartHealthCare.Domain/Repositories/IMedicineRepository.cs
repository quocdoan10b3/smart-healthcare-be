using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;
public class MedicineResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }
    public string Effect { get; set; } = null!;
    public string ImageMedicine { get; set; } = null!;
}
public interface IMedicineRepository : IRepositoryBase<Medicine>
{
    
    public IQueryable<Medicine> Search(string? search);
    public Task<IQueryable<MedicineResponse>> GetAggregatedMedicinesAsync(string? search);
}