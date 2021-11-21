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
    public class CommentMap:IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired(true);
            builder.Property(c => c.ModifiedByName).IsRequired(true);
            builder.Property(c => c.CreatedDate).IsRequired(true);
            builder.Property(c => c.ModifiedDate).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            builder.HasData(new Comment{
            
                Id = 1,
                ArticleId = 1,
                Text = "lorem ipsum",
                CreatedByName = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                Note = "First comment"
            },
            new Comment
            {
                Id = 2,
                ArticleId = 2,
                Text = "lorem ipsum",
                CreatedByName = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Admin",
                ModifiedDate = DateTime.Now,
                Note = "First comment"
            });
        }
    }
}
