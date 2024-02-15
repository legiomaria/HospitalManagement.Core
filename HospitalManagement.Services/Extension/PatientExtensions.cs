using Hospital.Core.Entities;
using Hospital.Services.Contracts.Patients;

namespace Hospital.Services.Extension
{
    public static class PatientExtensions
    {
        public static Patient AsEntity(this PatientCreateReq req)
        {
            return new Patient
            {
               FirstName = req.FirstName,
               MiddleName = req.MiddleName,
               LastName = req.LastName,
               CreatedBy = "Me",
               Address = req.Address,
               Phone = req.Phone,
               DateCreated = DateTime.UtcNow

            };
        }

        public static Patient AsEntity(this PatientUpdateReq req)
        {
            return new Patient
            {
                Id = req.Id,
                FirstName = req.FirstName,
                MiddleName = req.MiddleName,
                LastName = req.LastName,
                ModifiedBy = "Me",
                Address = req.Address,
                Phone = req.Phone,
                DateModified = DateTime.UtcNow

            };
        }

        public static PatientDto AsDto(this Patient entity)
        {
            return new PatientDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Address = entity.Address,
                Phone = entity.Phone
                

            };
        }

        public static List<PatientDto> AsDtos(this List<Patient> entities)
        {
            var patientDtos = new List<PatientDto>();

            foreach (Patient entity in entities)
            {
                patientDtos.Add(entity.AsDto());
            }

            return patientDtos;
        }
    }
}
