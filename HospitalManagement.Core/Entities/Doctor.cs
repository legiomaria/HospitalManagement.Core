namespace Hospital.Core.Entities
{
    public class Doctor : Entity
    {

        public string FirstName { set; get; } = string.Empty;

        public string MiddleName { set; get; } = string.Empty;

        public string LastName { set; get; } = string.Empty;

        public string Email { set; get; } = string.Empty;

        public string Phone { set; get; } = string.Empty;


        public ICollection<Patient>? Patients { set; get; }
    }
}
