using System.ComponentModel.DataAnnotations;

using static HouseRentingSystem.Infrastructure.Data.DataConstants.CategoryConstants;

namespace HouseRentingSystem.Infrastructure.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [StringLength(MaxCategoryNameLength)]
        public string Name { get; set; } = null!;

        public List<House> Houses { get; set; } = new List<House>();
    }
}
