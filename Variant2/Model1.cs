using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Variant2
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Login> Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drivers>()
                .Property(e => e.PassportSerial)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.PasportNumber)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Postcode)
                .IsFixedLength();
        }
    }
}
