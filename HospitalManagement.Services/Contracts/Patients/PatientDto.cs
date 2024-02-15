namespace Hospital.Services.Contracts.Patients
{
    public class PatientDto
    {
        public Guid Id { set; get; }

        public string FirstName { set; get; } = string.Empty;

        public string MiddleName { set; get; } = string.Empty;

        public string LastName { set; get; } = string.Empty;

        public string Address { set; get; } = string.Empty;

        public string Phone { set; get; } = string.Empty;
    }
}
