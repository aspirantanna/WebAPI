using GeekQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeekQuiz.Controllers
{
    public class StateController : ApiController
    {
        static readonly IStateRepository repository = new StateRepository();

        public IEnumerable<State> GetStates()
        {
            return repository.GetAll();
        }

        public State GetState(int id)
        {
            State item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public State PostState(State item)
        {
            item = repository.Add(item);
            return item;
        }
    }
}
