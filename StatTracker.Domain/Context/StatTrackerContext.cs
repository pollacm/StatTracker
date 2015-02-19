using Ninject;
using StatTracker.Domain.Objects;

namespace StatTracker.Domain.Context
{
    public class StatTrackerContext : IStatTrackerContext
    {
        public StatTrackerContext()
        {
            Kernel = new StandardKernel(new RepositoryModule());
        }

        public IKernel Kernel { get; set; }
    }
}