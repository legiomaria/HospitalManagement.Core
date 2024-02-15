using Hospital.Core.Entities;
using Hospital.Core.Interfaces;
using Hospital.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositories.Implementations
{
    public class MedicineRepository : IMedicineRepository
    {
        private HospitalContext _hospitalContext;

        public MedicineRepository(HospitalContext hospitalContext)
        {
            _hospitalContext = hospitalContext;
        }

        public async Task<Medicine> Add(Medicine medicine)
        {
            _hospitalContext.Add(medicine);
            _hospitalContext.SaveChanges();
            return await Task.FromResult(medicine);
        }

        public async Task<bool> Delete(Guid medicineId)
        {
            var medicine = await _hospitalContext
                         .Medicines
                         .Where(m => m.Id == medicineId)
                         .FirstOrDefaultAsync();

            _hospitalContext
            .Medicines
            .Remove(medicine ?? new Medicine());

            return _hospitalContext.SaveChanges() > 0 ? true : false;
        }

        public async Task<List<Medicine>> GetAll()
        {
            return await Task.FromResult(_hospitalContext
                .Medicines
                .ToList());
        }

        public async Task<Medicine> GetById(Guid medicineId)
        {
            var medicine = await _hospitalContext
                           .Medicines
                           .Where(m => m.Id == medicineId)
                           .FirstOrDefaultAsync();

            return medicine ?? new Medicine();

        }

        public async Task<Medicine> Update(Medicine medicine)
        {
            var update = _hospitalContext.Medicines.Update(medicine);
            _hospitalContext.SaveChanges();

            return await Task.FromResult(medicine);
        }
    }
}
