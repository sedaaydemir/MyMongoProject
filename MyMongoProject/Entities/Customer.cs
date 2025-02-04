namespace MyMongoProject.Entities
{
    public class Customer
    {
        public string CustomerId { get; set; } //mongo db de string olarak gelıyor ıd
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
