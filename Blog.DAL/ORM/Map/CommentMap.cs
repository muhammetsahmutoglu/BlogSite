using Blog.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.Map
{
   public class CommentMap:BaseMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Content).IsOptional();
            Property(x => x.Header).IsOptional();
            Property(x => x.CommentNumber).IsOptional();
            HasKey(x => new { x.AppUserID, x.ArticleID });
        }
    }
}
