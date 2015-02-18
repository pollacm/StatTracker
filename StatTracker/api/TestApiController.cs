using System.Collections.Generic;
using System.Web.Http;
using StatTracker.Domain;
using StatTracker.Domain.Objects;
using StatTracker.Repository.Mock;

namespace StatTracker.api
{
    [RoutePrefix("api/testapi")]
    public class TestApiController : ApiController
    {
        private readonly TestDomain _testDomain = new TestDomain(new TestRepositoryMock());

        //GET api/testapi/all
        [HttpGet]
        [Route("All", Name = "All")]
        public IEnumerable<Test> GetAllTests()
        {
            return _testDomain.GetTestData();
        }

        //GET api/testapi/get/Curtis
        [HttpGet]
        [Route("Get/{firstName}", Name = "Get")]
        public IHttpActionResult Get(string firstName)
        {
            var test = _testDomain.GetTestByFirstName(firstName);
            
            if (test == null)
            {
                return NotFound();
            }

            return Ok(test);
        }
    }
}