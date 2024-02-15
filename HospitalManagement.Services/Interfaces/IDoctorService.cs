using Hospital.Services.Contracts.Doctor;
using Hospital.Services.Contracts.Doctors;

namespace Hospital.Services.Interfaces
{
    public interface IDoctorService
    {
        DoctorRsp<DoctorDto> Create(DoctorCreateReq req);

        Task<DoctorRsp<DoctorDto>> GetById(Guid doctorId);

        Task<DoctorRsp<List<DoctorDto>>> GetAll();

        Task<DoctorRsp<DoctorDto>> Update(DoctorUpdateReq req);

        Task<DoctorRsp<bool>> Delete(Guid id);


    }
}
