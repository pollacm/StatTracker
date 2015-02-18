using System;
using System.Collections.Generic;
using StatTracker.Domain.Objects;
using StatTracker.Repository.Interfaces;

namespace StatTracker.Repository
{
    public class TestRepository : ITestRepository
    {
        public IEnumerable<Test> GetTestData()
        {
            throw new NotImplementedException();
        }
    }
}