﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTMusic.DataAccess.Interfaces;
using UTMusic.DataAccess.Repositories;
using Ninject.Modules;

namespace UTMusic.BusinessLogic.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private readonly string connectionString;
        public ServiceModule(string connection) {
            connectionString = connection;
        }
        public override void Load() {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
