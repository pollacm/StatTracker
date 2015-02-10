using System.Collections.Generic;
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

        public List<Test> GetTestData()
        {
            return _repository.GetTestData();
        }
    }
}