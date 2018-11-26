using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMM.Models;

namespace WebAppMM.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppMM.Models.Place> Places { get; set; }
        public DbSet<WebAppMM.Models.User> Users { get; set; }
    }
}
