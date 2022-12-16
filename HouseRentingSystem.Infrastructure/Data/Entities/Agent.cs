using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HouseRentingSystem.Infrastructure.Data.DataConstants.AgentConstants;

namespace HouseRentingSystem.Infrastructure.Data.Entities
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
