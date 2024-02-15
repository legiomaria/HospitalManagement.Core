using Hospital.Services.Contracts.Doctor;
using Hospital.Services.Contracts.Doctors;
using Hospital.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Presentation.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILogger<DoctorController> _logger;

        private readonly IDoctorService _doctorService;

        public DoctorController(
            IDoctorService doctorService,
            ILogger<DoctorController> logger
            )
        {
            _doctorService = doctorService;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<DoctorRsp<DoctorDto>> Create(
        [FromBody]DoctorCreateReq req)
        {
           return _doctorService.Create(req);
        }

        [HttpGet]
        public async Task<ActionResult<DoctorRsp<List<DoctorDto>>>> GetAll()
        {
            return await _doctorService.GetAll();
        }

        [HttpGet]
        [Route("{doctorId}")]
        public async Task<ActionResult<DoctorRsp<DoctorDto>>> Get(Guid doctorId )
        {
            return await _doctorService.GetById(doctorId);
        }

        [HttpPut]
        [Route("{doctorId}")] 
        public async Task<ActionResult<DoctorRsp<DoctorDto>>> Update(
            Guid doctorid, 
            [FromBody]DoctorUpdateReq req)
        {
            return await _doctorService.Update(req);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<DoctorRsp<bool>>> Delete(string id)
        {
            return await _doctorService.Delete(new Guid(id));      
        }
    }
}
