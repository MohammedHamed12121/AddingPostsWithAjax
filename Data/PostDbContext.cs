using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PopupsWebWithAjax.Models;

namespace PopupsWebWithAjax.Data
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
    }
}