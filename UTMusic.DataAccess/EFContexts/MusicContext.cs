using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UTMusic.DataAccess.Entities;
using UTMusic.DataAccess.Interfaces;
using UTMusic.DataAccess.Repositories;

namespace UTMusic.DataAccess.EFContexts
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<IdNumber> IdNumbers { get; set; }
        public MusicContext(string connectionString)
            : base(connectionString) { }
    }
}