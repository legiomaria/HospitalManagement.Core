namespace Hospital.Services.Contracts.Doctor
{
    public class DoctorUpdateReq : DoctorCreateReq
    {
        public Guid Id { get; set; }
    }
}
