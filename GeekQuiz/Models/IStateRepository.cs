using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
        State Get(int id);
        State Add(State item);
        void Remove(int id);
        bool Update(State item);
    }
}