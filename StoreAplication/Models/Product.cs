namespace StoreAplication.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; }
    }
}
