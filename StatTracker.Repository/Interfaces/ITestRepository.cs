using System.Collections.Generic;
using StatTracker.Domain.Objects;

namespace StatTracker.Repository.Interfaces
{
    public interface ITestRepository
    {
        List<Test> GetTestData();
    }
}