using System.Data.Entity.ModelConfiguration;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.DAL.EF.Mapping
{
    public class PhoneNumberTypeMap : EntityTypeConfiguration<PhoneNumberType>
    {
        public PhoneNumberTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PhoneNumberTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PhoneNumberType", "Person");
            this.Property(t => t.PhoneNumberTypeID).HasColumnName("PhoneNumberTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
