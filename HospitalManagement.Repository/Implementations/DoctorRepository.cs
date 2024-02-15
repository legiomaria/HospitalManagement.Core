using Hospital.Core.Entities;
using Hospital.Core.Interfaces;
using Hospital.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositories.Implementations
{
    public class DoctorRepository : IDoctorRepository
    {
        private HospitalContext _hospitalContext;

        public DoctorRepository(HospitalContext hospitalContext)
        {
            _hospitalContext = hospitalContext;
        }

        public async Task<Doctor> Add(Doctor doctor)
        {
            _hospitalContext.Add(doctor);
            _hospitalContext.SaveChanges();
            return await Task.FromResult(doctor);
        }

        public async Task<bool> Delete(Guid doctorId)
        {
            var doctor = await _hospitalContext
                       .Doctors
                       .Where(m => m.Id == doctorId)
                       .FirstOrDefaultAsync();

            _hospitalContext
             .Doctors
             .Remove(doctor ?? new Doctor());

            return _hospitalContext.SaveChanges() > 0 ? true : false;
        }

        public async Task<List<Doctor>> GetAll()
        {
           return await Task.FromResult(_hospitalContext
               .Doctors
               .ToList());
        }

        public async Task<Doctor?> GetById(Guid doctorId)
        {
            Doctor? doctor = await _hospitalContext
                        .Doctors
                        .Where(m => m.Id == doctorId)
                        .FirstOrDefaultAsync();

            return doctor;
        }

        public async Task<Doctor> Update(Doctor doctor)
        {
            var update = _hospitalContext.Doctors.Update(doctor);
            _hospitalContext.SaveChanges();

            return await Task.FromResult(doctor);
        }
    }
}
