namespace CarRental.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal PricePerDay { get; set; }
        public bool Availability { get; set; } = true;
    }
}
