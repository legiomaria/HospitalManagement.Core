using Hospital.Core.Entities;
using Hospital.Services.Contracts.Doctor;
using Hospital.Services.Contracts.Doctors;

namespace Hospital.Services.Extension
{
    public static class DoctorExtensions
    {
       public static Doctor AsEntity(this DoctorCreateReq req)
        {
            return new Doctor
            {
               FirstName = req.FirstName,
               MiddleName = req.MiddleName,
               LastName = req.LastName,
               Email = req.Email,
               Phone = req.Phone,
               CreatedBy = "Me",
               DateCreated = DateTime.UtcNow

            };
        }

        public static Doctor AsEntity(this DoctorUpdateReq req)
        {
            return new Doctor
            {
                Id = req.Id,
                FirstName = req.FirstName,
                MiddleName = req.MiddleName,
                LastName = req.LastName,
                Email = req.Email,
                Phone = req.Phone,
                ModifiedBy = "Me",
                DateModified = DateTime.UtcNow

            };
        }

        public static DoctorDto AsDto(this Doctor entity)
        {
            return new DoctorDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Email = entity.Email,
                Phone = entity.Phone,
                

            };
        }

        public static List<DoctorDto> AsDto(this List<Doctor> entities)
        {
            var doctorDtos = new List<DoctorDto>();

            foreach (Doctor entity in entities)
            {
                doctorDtos.Add(entity.AsDto());
            }

            return doctorDtos;
        }
    }
}
