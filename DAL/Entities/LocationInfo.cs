using System.ComponentModel.DataAnnotations;

namespace Inventory_Api.Models.Entities
{
    public class LocationInfo
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        [MaxLength(4)]
        public string LocationCode { get; set; }
        [MaxLength(50)]
        public string LocationName { get; set; }
    }
}
