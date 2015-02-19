using System.Web.Mvc;
using StatTracker.Domain;
using StatTracker.Repository.Mock;

namespace StatTracker.Controllers
{
    public class TestController : StatTrackerControllerBase
    {
        private readonly TestDomain _testDomain;

        public TestController()
        {
            _testDomain = new TestDomain(StatTrackerContext);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}