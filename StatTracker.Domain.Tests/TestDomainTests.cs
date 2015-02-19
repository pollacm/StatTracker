using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatTracker.Domain.Tests
{
    [TestClass]
    public class TestDomainTests
    {
        private TestDomain TestDomain { get; set; }

        public TestDomainTests()
        {
            TestDomain = new TestDomain(new StatTrackerContextMock());
        }

        [TestMethod]
        public void TestMethod1()
        {
            var test = TestDomain.GetTestByFirstName("Curtis");
        }
    }
}
