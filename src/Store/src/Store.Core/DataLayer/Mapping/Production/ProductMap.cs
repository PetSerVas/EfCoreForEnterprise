using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.Production;

namespace Store.Core.DataLayer.Mapping.Production
{
    public class ProductMap : IEntityMap
	{
		public void Map(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<Product>();
			
			entity.ToTable("Product", "Production");
			
			entity.HasKey(p => p.ProductID);
			
			entity.Property(p => p.ProductID).UseSqlServerIdentityColumn();
			
			entity.Property(p => p.ProductName).HasColumnType("varchar(100)").IsRequired();
			
			entity.Property(p => p.Description).HasColumnType("varchar(255)");

            entity.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
        }
	}
}
