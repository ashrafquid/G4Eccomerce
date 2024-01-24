namespace G4Eccomerce.Model
{
    public class Product
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; } = 0;
        public int Qty { get; set; }
        public string? Details { get; set; }
        public int? CategoryId { get; set; }


    }
}
