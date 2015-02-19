using Ninject;

namespace StatTracker.Domain.Context
{
    public interface IStatTrackerContext
    {
        IKernel Kernel { get; set; }
    }
}