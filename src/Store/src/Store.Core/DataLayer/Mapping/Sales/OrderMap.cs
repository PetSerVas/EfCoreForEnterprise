using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Mapping.Sales
{
    public class OrderMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Order>();

            entity.ToTable("Order", "Sales");

            entity.HasKey(p => p.OrderID);

            entity.Property(p => p.OrderID).UseSqlServerIdentityColumn();

            entity.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
        }
    }
}
