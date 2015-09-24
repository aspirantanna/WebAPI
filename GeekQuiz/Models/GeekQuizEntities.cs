using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class GeekQuizEntities : DbContext
    {
        public GeekQuizEntities()
            : base("GeekQuizEntities")
        {
            
        }
        public DbSet<State> States { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}