using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HouseRentingSystem.Infrastructure.Data.DataConstants.HouseConstants;

namespace HouseRentingSystem.Infrastructure.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxAddressLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Column(TypeName="money")]
        [Precision(18,2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public IdentityUser? Renter { get; set; }
    }
}
