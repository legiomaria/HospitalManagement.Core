using Hospital.Services.Contracts.Patients;

namespace Hospital.Services.Interfaces
{
    public interface IPatientService
    {
        PatientRsp<PatientDto> Create(PatientCreateReq req);

       Task<PatientRsp<PatientDto>> GetById(Guid patientId);

       Task<PatientRsp<List<PatientDto>>> GetAll();

        Task<PatientRsp<bool>> Delete(Guid id);

        Task<PatientRsp<PatientDto>> Update(PatientUpdateReq req);


    }
}
