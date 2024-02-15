namespace Hospital.Core.Entities
{
    public class Patient : Entity
    {

        public string FirstName { set; get; } = string.Empty;

        public string MiddleName { set; get; } = string.Empty;

        public string LastName { set; get; } = string.Empty;

        public string Address { set; get; } = string.Empty;

        public string Phone { set; get; } = string.Empty;


        public ICollection<Medicine>? Medicines { set; get; }
    }
}
