using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace cpe05api.Models.Mapping
{
    public class UserInfoMap : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Firstname)
                .HasMaxLength(50);

            this.Property(t => t.Middlename)
                .HasMaxLength(50);

            this.Property(t => t.Lastname)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Middlename).HasColumnName("Middlename");
            this.Property(t => t.Lastname).HasColumnName("Lastname");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
