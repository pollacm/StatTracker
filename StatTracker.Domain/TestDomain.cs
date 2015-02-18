using System;
using System.Collections.Generic;
using System.Linq;
using StatTracker.Domain.Objects;
using StatTracker.Repository;
using StatTracker.Repository.Interfaces;

namespace StatTracker.Domain
{
    public class TestDomain
    {
        private readonly ITestRepository _repository;

        public TestDomain(ITestRepository repository = null)
        {
            _repository = repository ?? new TestRepository();
        }

        public IEnumerable<Test> GetTestData()
        {
            return _repository.GetTestData().ToList();
        }

        public Test GetTestByFirstName(string firstName)
        {
            return _repository.GetTestData().SingleOrDefault(t => String.Equals(t.FirstName, firstName, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}