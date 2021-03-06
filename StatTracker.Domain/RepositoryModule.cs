﻿using Ninject.Modules;
using StatTracker.Repository.Interfaces;
using StatTracker.Repository.Mock;

namespace StatTracker.Domain
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<ITestRepository>().To<TestRepository>();
            Bind<ITestRepository>().To<TestRepositoryMock>();
        }
    }
}