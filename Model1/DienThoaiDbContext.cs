using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model1
{
    public partial class DienThoaiDbContext : DbContext
    {
        public DienThoaiDbContext()
            : base("name=DienThoaiDbContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SDT)
                .IsUnicode(false);
        }
    }
}
