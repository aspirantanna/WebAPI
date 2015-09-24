using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class DatabaseFactory:  IDatabaseFactory
    {
        private GeekQuizEntities dataContext;

        public GeekQuizEntities Get()
        {
            return dataContext ?? (dataContext = new GeekQuizEntities());
        }
    }
}