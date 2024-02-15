using Hospital.Core.Entities;
using Hospital.Core.Interfaces;
using Hospital.Services.Contracts.Patients;
using Hospital.Services.Extension;
using Hospital.Services.Interfaces;

namespace Hospital.Services.Implementations
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public PatientRsp<PatientDto> Create(PatientCreateReq req)
        {
            var newPatient = req.AsEntity();
            _repository.Add(newPatient);

            return new PatientRsp<PatientDto>
            {
                Code = "200",
                Message = String.Empty
            };
        }

        public async Task<PatientRsp<bool>> Delete(Guid id)
        {
            var result = await _repository.Delete(id);

            return new PatientRsp<bool>
            {
                Code = "200",
                Message = string.Empty,
                Result = result
            };
        }

        public async Task<PatientRsp<List<PatientDto>>> GetAll()
        {
            var result = await _repository.GetAll();

            return new PatientRsp<List<PatientDto>>
            {
                Code = "200",
                Message = String.Empty,
                Result = result.AsDtos()
            };
        }

        public async Task<PatientRsp<PatientDto>> GetById(Guid patientId)
        {
            var result = await _repository.GetById(patientId);

            if(result == null)
            {
                return new PatientRsp<PatientDto>
                {
                    Code = "Patient.NotFound",
                    Message = "Patient was not found",
                };
            }

            return new PatientRsp<PatientDto>
            {
                Code = "200",
                Message = string.Empty,
                Result = result.AsDto()
            };
        }

        public async Task<PatientRsp<PatientDto>> Update(PatientUpdateReq req)
        {
            var toUpdate = req.AsEntity();

          var update =  await _repository.Update(toUpdate);

            return new PatientRsp<PatientDto>
            {
                Code = "200",
                Message = string.Empty,
                Result = update.AsDto()
            };
        }
    }
}
