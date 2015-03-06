using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using StatTracker.Domain.Context;
using StatTracker.Domain.Objects;
using StatTracker.Repository.Interfaces;

namespace StatTracker.Domain
{
    public class TestDomain
    {
        private readonly ITestRepository _repository;

        public TestDomain(IStatTrackerContext context)
        {
            _repository = context.Kernel.Get<ITestRepository>();
        }

        public IEnumerable<Test> GetTestData()
        {
            return _repository.GetTestData();
        }

        public Test GetTestByFirstName(string firstName)
        {
            return _repository.GetTestData().SingleOrDefault(t => String.Equals(t.FirstName, firstName, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}