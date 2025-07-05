namespace RetailInventory.Models
{
    public class Product
    {
        public int ProductId { get; set; }    
        public string Name { get; set; }
        public string Category { get; set; }
        public int StockQuantity { get; set; }
    }
}
