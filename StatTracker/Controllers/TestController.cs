using System.Web.Mvc;
using StatTracker.Domain;
using StatTracker.Repository.Mock;

namespace StatTracker.Controllers
{
    public class TestController : Controller
    {
        private readonly TestDomain _testDomain = new TestDomain(new TestRepositoryMock());

        public ActionResult Index()
        {
            return View(_testDomain.GetTestData());
        }
    }
}