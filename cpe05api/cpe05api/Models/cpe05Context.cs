using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using cpe05api.Models.Mapping;

namespace cpe05api.Models
{
    public partial class cpe05Context : DbContext
    {
        static cpe05Context()
        {
            Database.SetInitializer<cpe05Context>(null);
        }

        public cpe05Context()
            : base("Name=cpe05Context")
        {
        }

        public DbSet<UserInfo> UserInfoes { get; set; }
        public DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserInfoMap());
            modelBuilder.Configurations.Add(new WeatherMap());
        }
    }
}
