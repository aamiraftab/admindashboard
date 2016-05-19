using System.Data.Entity.ModelConfiguration;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.DAL.EF.Mapping
{
    public class IllustrationMap : EntityTypeConfiguration<Illustration>
    {
        public IllustrationMap()
        {
            // Primary Key
            this.HasKey(t => t.IllustrationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Illustration", "Production");
            this.Property(t => t.IllustrationID).HasColumnName("IllustrationID");
            this.Property(t => t.Diagram).HasColumnName("Diagram");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
