using Hospital.Core.Entities;
using Hospital.Core.Interfaces;
using Hospital.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositories.Implementations
{
    public class PatientRepository : IPatientRepository
    {
        private HospitalContext _hospitalContext;

        public PatientRepository(HospitalContext hospitalContext)
        {
            _hospitalContext = hospitalContext;
        }

        public async Task<Patient> Add(Patient patient)
        {
            _hospitalContext.Add(patient);
            _hospitalContext.SaveChanges();
            return await Task.FromResult(patient);
        }

        public async Task<bool> Delete(Guid patientId)
        {
            var patient = await _hospitalContext
                          .Patients
                          .Where(m => m.Id == patientId)
                          .FirstOrDefaultAsync();

            _hospitalContext
            .Patients
            .Remove(patient ?? new Patient());

            return _hospitalContext.SaveChanges() > 0 ? true : false;
        }

        public async Task<List<Patient>> GetAll()
        {
            return await Task.FromResult(
                _hospitalContext
                .Patients
                .ToList());
        }

        public async Task<Patient?> GetById(Guid patientId)
        {
            Patient? patient = await _hospitalContext
                          .Patients
                          .Where(m => m.Id == patientId)
                          .FirstOrDefaultAsync();

            return patient;
        }

        public async Task<Patient> Update(Patient patient)
        {
            var update = _hospitalContext.Patients.Update(patient);
            _hospitalContext.SaveChanges();

            return await Task.FromResult(patient);

        }
    }
}
