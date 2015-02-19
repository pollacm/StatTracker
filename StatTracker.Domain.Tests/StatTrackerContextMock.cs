using Ninject;
using StatTracker.Domain.Context;

namespace StatTracker.Domain.Tests
{
    public class StatTrackerContextMock : IStatTrackerContext
    {
        public StatTrackerContextMock()
        {
            Kernel = new StandardKernel(new RepositoryModuleMock());
        }

        public IKernel Kernel { get; set; }
    }
}