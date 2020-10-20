﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTMusic.DataAccess.Entities;
namespace UTMusic.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Song, int> Songs { get; }
        IRepository<IdNumber, int> IdNumbers { get; }
        void Save();
        Task SaveAsync();
    }
}
