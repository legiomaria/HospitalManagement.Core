namespace Hospital.Services.Contracts.Doctors
{
    public class DoctorRsp<T>
    {
        public string Code { set; get; } = string.Empty;

        public string? Message { set; get; }

        public T? Result { set; get; }
    }
}
