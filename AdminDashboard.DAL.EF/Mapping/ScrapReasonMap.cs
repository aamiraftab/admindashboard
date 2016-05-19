using System.Data.Entity.ModelConfiguration;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.DAL.EF.Mapping
{
    public class ScrapReasonMap : EntityTypeConfiguration<ScrapReason>
    {
        public ScrapReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.ScrapReasonID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScrapReason", "Production");
            this.Property(t => t.ScrapReasonID).HasColumnName("ScrapReasonID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
