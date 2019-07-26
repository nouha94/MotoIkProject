using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class MyContext : DbContext
    {
        public MyContext() : base("Name = DefaultConnection")
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());

        }
        public class MyContextInitializer : DropCreateDatabaseIfModelChanges<MyContext>
        {
            protected override void Seed(MyContext ctx)
            {
                base.Seed(ctx);
            }
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleRequest> VehicleRequests { get; set; }
        public DbSet<Client>Clients { get; set; }


        //   public System.Data.Entity.DbSet<Web.Models.VehicleModels> VehicleModels { get; set; }
    }
}
