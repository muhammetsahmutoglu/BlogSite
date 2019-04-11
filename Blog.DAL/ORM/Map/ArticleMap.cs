using Blog.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.Map
{
   public class ArticleMap:BaseMap<Article>
    {
        public ArticleMap()
        {
            ToTable("dbo.Articles");
            Property(x => x.Content).IsRequired();
            Property(x => x.Header).IsRequired();

            HasRequired(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.AppUser)
               .WithMany(x => x.Articles)
               .HasForeignKey(x => x.AppUSerID)
               .WillCascadeOnDelete(false);

            HasMany(x => x.Comments)
                .WithRequired(x => x.Article)
                .HasForeignKey(x => x.ArticleID)
                .WillCascadeOnDelete(false);

            HasMany(x => x.Likes)
               .WithRequired(x => x.Article)
               .HasForeignKey(x => x.ArticleID)
               .WillCascadeOnDelete(false);


        }
    }
}
