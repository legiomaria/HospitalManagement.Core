namespace Hospital.Services.Contracts.Patients
{
    public class PatientUpdateReq : PatientCreateReq
    {
        public Guid Id { set; get; }
    }
}
