using Hospital.Services.Contracts.Patients;
using Hospital.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Presentation.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;

        private readonly IPatientService _patientService;

        public PatientController(
            IPatientService patientService,
            ILogger<PatientController> logger)
        {
            _patientService = patientService;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<PatientRsp<PatientDto>> Create(
            [FromBody]PatientCreateReq req)
        {
            return _patientService.Create(req);
        }

        [HttpGet]
        public async Task<ActionResult<PatientRsp<List<PatientDto>>>> GetAll()
        {
            return await _patientService.GetAll();
        }

        [HttpGet]
        [Route("{patientId}")]
        public async Task<ActionResult<PatientRsp<PatientDto>>> Get(Guid patientId)
        {
            return await _patientService.GetById(patientId);
        }

        [HttpPut]
        public async Task<ActionResult<PatientRsp<PatientDto>>> Update(
            [FromRoute]Guid id, 
            [FromBody]PatientUpdateReq req)
        {
            return await _patientService.Update(req);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<PatientRsp<bool>>> Delete(string id)
        {
            return await _patientService.Delete(new Guid(id));
        }


    }
}
