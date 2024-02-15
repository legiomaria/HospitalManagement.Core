using Hospital.Core.Entities;

namespace Hospital.Core.Interfaces
{
    public interface IDoctorRepository
    {
        Task<Doctor> Add(Doctor doctor);

        Task<Doctor> Update(Doctor doctor);

        Task<Doctor?> GetById(Guid doctorId);

        Task<List<Doctor>> GetAll();

        Task<bool> Delete(Guid doctorId);
    }
}
