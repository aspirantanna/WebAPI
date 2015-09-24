using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class StateRepository:IStateRepository
    {
        IDatabaseFactory db;
        private readonly DbSet<State> dbset;
        public StateRepository(IDatabaseFactory databaseFactory)
        {
            db = databaseFactory;
            dbset = DataContext.Set
        }

        public StateRepository():this(new DatabaseFactory())
        {

        }

        private List<State> states = new List<State>();
        private int _nextId = 1;

        //public StateRepository()
        //{
        //    Add(new State { StateName = "TamilNadu"});
        //    Add(new State { StateName = "Andhra Paradesh"});
        //    Add(new State { StateName = "Karnataka" });
        //}

        public IEnumerable<State> GetAll()
        {
            return states;
        }

        public State Get(int id)
        {
            return states.Find(p => p.ID == id);
        }

        public State Add(State item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.ID = _nextId++;
            states.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            states.RemoveAll(p => p.ID == id);
        }

        public bool Update(State item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = states.FindIndex(p => p.ID == item.ID);

            if (index == -1)
            {
                return false;
            }
            states.RemoveAt(index);
            states.Add(item);
            return true;
        }
    }
}