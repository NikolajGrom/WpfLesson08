using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfLesson08
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Reg_Liapota_Model")
        {
        }

        public virtual DbSet<LoginUser> LoginUser { get; set; }
        public virtual DbSet<Pass_Reset_History> Pass_Reset_History { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginUser>()
                .HasMany(e => e.Pass_Reset_History)
                .WithRequired(e => e.LoginUser)
                .HasForeignKey(e => e.FK_loginNameId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoginUser>()
                .HasMany(e => e.User)
                .WithRequired(e => e.LoginUser)
                .HasForeignKey(e => e.Fk_LoginId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRoles>()
                .HasMany(e => e.User)
                .WithRequired(e => e.UserRoles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);
        }
    }
}
