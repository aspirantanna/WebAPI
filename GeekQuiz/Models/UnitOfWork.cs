using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;

        private GeekQuizEntities dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected GeekQuizEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }
    }
}