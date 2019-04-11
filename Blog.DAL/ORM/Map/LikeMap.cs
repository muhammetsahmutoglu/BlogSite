using Blog.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.Map
{
    class LikeMap:BaseMap<Like>
    {
        public LikeMap()
        {
            ToTable("dbo.Likes");
            Property(x => x.LikeNumber).IsOptional();
            HasKey(x => new { x.AppUserID, x.ArticleID });
        }

    }
}
