using System.Web.Mvc;
using StatTracker.Domain.Context;

namespace StatTracker.Controllers
{
    public class StatTrackerControllerBase : Controller
    {
        protected readonly StatTrackerContext StatTrackerContext;

        protected StatTrackerControllerBase()
        { 
            StatTrackerContext = new StatTrackerContext();
        }
    }
}