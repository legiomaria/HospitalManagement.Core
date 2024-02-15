using Hospital.Core.Entities;

namespace Hospital.Core.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient> Add(Patient patient);

        Task<Patient> Update(Patient patient);

        Task<Patient?> GetById(Guid patientId);

        Task<List<Patient>> GetAll();

        Task<bool> Delete(Guid patientId);
    }
}
