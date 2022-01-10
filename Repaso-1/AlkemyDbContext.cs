using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repaso_1.Models;

namespace Repaso_1
{
    class AlkemyDbContext : DbContext
    {
        public AlkemyDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
