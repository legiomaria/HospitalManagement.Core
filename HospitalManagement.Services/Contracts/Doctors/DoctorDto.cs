namespace Hospital.Services.Contracts.Doctors
{
    public class DoctorDto
    {
        public Guid Id { set; get; }

        public string FirstName { set; get; } = string.Empty;

        public string MiddleName { set; get; } = string.Empty;

        public string LastName { set; get; } = string.Empty;

        public string Email { set; get; } = string.Empty;

        public string Phone { set; get; } = string.Empty;
    }
}
