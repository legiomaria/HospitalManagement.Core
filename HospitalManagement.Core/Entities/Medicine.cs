namespace Hospital.Core.Entities
{
    public class Medicine : Entity
    {
        public string Name { set; get; } = string.Empty;

        public double Quantity { set; get; }

        public double Price { set; get; }
    }
}
