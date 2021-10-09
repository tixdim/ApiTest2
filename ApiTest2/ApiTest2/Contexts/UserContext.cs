using ApiTest2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest2.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> option) : base(option) { }
        public DbSet<User> Users { get; set; }
    }
}
