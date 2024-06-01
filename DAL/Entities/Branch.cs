using System.ComponentModel.DataAnnotations;

namespace Inventory_Api.Models.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        [MaxLength(4)]
        public string BranchCode { get; set; }
        [MaxLength(50)]
        public string BranchName { get; set; }
    }
}
