using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentMvcEntity.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string CityOperatesIn { get; set; }

        
    }
}
