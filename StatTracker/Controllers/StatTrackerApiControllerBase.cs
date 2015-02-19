using System.Web.Http;
using StatTracker.Domain.Context;

namespace StatTracker.Controllers
{
    public class StatTrackerApiControllerBase : ApiController
    {
        protected readonly StatTrackerContext StatTrackerContext;

        protected StatTrackerApiControllerBase()
        { 
            StatTrackerContext = new StatTrackerContext();
        }
    }
}