namespace MVCDemoAssignment.Models
{
    public class Inventory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int QtyInStock { get; set; }

        public DateTime LastDate { get; set; }

        public Supplier Supplier { get; set; } 
    }
}
