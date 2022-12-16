using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {


            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Cottage"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Single-Family"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Duplex"
                }
            };

            return categories;

        }
    }
}
