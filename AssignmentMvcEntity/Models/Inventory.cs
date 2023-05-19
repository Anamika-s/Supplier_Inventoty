namespace AssignmentMvcEntity.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int QtyInStock { get; set; }
        public DateTime LastUpdated { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
