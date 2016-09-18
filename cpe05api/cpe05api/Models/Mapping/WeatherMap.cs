using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace cpe05api.Models.Mapping
{
    public class WeatherMap : EntityTypeConfiguration<Weather>
    {
        public WeatherMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.humidity)
                .HasMaxLength(50);

            this.Property(t => t.temperature_celcius)
                .HasMaxLength(50);

            this.Property(t => t.temperature_fahrenheit)
                .HasMaxLength(50);

            this.Property(t => t.location)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Weather");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.humidity).HasColumnName("humidity");
            this.Property(t => t.temperature_celcius).HasColumnName("temperature_celcius");
            this.Property(t => t.temperature_fahrenheit).HasColumnName("temperature_fahrenheit");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.createdon).HasColumnName("createdon");
        }
    }
}
