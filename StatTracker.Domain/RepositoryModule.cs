using Ninject.Modules;
using StatTracker.Repository;
using StatTracker.Repository.Interfaces;

namespace StatTracker.Domain
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestRepository>().To<TestRepository>();
        }
    }
}