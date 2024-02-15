namespace Hospital.Services.Contracts.Patients
{
    public class PatientRsp<T>
    {
        public string Code { set; get; } = string.Empty;

        public string Message { set; get; } = string.Empty;

        public T? Result { set; get; }
    }
}
