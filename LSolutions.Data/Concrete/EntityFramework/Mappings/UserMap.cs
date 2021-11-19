using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSolutions.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LSolutions.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Name).HasMaxLength(25);
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Username).HasMaxLength(20);
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Description).IsRequired(false);
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.User).HasForeignKey(u => u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired(true);
            builder.Property(u => u.ModifiedByName).IsRequired(true);
            builder.Property(u => u.CreatedDate).IsRequired(true);
            builder.Property(u => u.ModifiedDate).IsRequired(true);
            builder.Property(u => u.IsActive).IsRequired(true);
            builder.Property(u => u.IsDeleted).IsRequired(true);
            builder.Property(u => u.Note).HasMaxLength(500);
            builder.ToTable("Users");


            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                Name = "Samet",
                LastName = "Türk",
                Username = "Extronic",
                Email = "sametsalihcnt@gmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "Initialcreate",
                ModifiedDate = DateTime.Now,
                Description = "Admin",
                Note = "Admin",
                PasswordHash = Encoding.ASCII.GetBytes("e10adc3949ba59abbe56e057f20f883e") //123456
            });


        }
    }
}
