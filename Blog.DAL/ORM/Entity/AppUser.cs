﻿using Blog.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.Entity
{
   public class AppUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public Role Role { get; set; }
        public Gender Gender { get; set; }

        public virtual List<Article> Articles { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<Like> Likes { get; set; }
    }
}
