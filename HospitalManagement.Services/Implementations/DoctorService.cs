using Hospital.Core.Entities;
using Hospital.Core.Interfaces;
using Hospital.Services.Contracts.Doctor;
using Hospital.Services.Contracts.Doctors;
using Hospital.Services.Extension;
using Hospital.Services.Interfaces;


namespace Hospital.Services.Implementations
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;

        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public DoctorRsp<DoctorDto> Create(DoctorCreateReq req)
        {
            var newDoctor = req.AsEntity();
            _repository.Add(newDoctor);

            return new DoctorRsp<DoctorDto>
            {
                Code = "200",
                Message = string.Empty
            };
        }

        public async Task<DoctorRsp<bool>> Delete(Guid id)
        {
            var result = await _repository.Delete(id);

            return new DoctorRsp<bool>
            {
                Code = "200",
                Message = string.Empty,
                Result = result
            };
        }

        public async Task<DoctorRsp<List<DoctorDto>>> GetAll()
        {
            var result = await _repository.GetAll();

            return new DoctorRsp<List<DoctorDto>>
            {
                Code = "200",
                Message = string.Empty,
                Result = result.AsDto()
            };

        }

        public async Task<DoctorRsp<DoctorDto>> GetById(Guid doctorId)
        {
            var result = await _repository.GetById(doctorId);

            if(result == null)
            {
                return new DoctorRsp<DoctorDto>
                {
                    Code = "Doctor.NotFound",
                    Message = "Doctor was not found",
                };
            }

            return new DoctorRsp<DoctorDto>
            {
                Code = "200",
                Message = string.Empty,
                Result = result.AsDto()
            };
        }

        public async Task<DoctorRsp<DoctorDto>> Update(DoctorUpdateReq req)
        {
            var toUpdate = req.AsEntity();

           var update = await _repository.Update(toUpdate);

            return new DoctorRsp<DoctorDto>
            {
                Code = "200",
                Message = string.Empty,
                Result = update.AsDto()
            };
        }
    }
}
