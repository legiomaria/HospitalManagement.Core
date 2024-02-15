using Hospital.Core.Entities;

namespace Hospital.Core.Interfaces
{
    public interface IMedicineRepository
    {
        Task<Medicine> Add(Medicine medicine);

        Task<Medicine> Update(Medicine medicine);

        Task<Medicine> GetById(Guid medicineId);

        Task<List<Medicine>> GetAll();

        Task<bool> Delete(Guid medicineId);
    }
}
