using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibrarySystem.Authorization.Roles;
using LibrarySystem.Authorization.Users;
using LibrarySystem.MultiTenancy;
using LibrarySystem.Entities;
using System.Diagnostics.Eventing.Reader;

namespace LibrarySystem.EntityFrameworkCore
{
    public class LibrarySystemDbContext : AbpZeroDbContext<Tenant, Role, User, LibrarySystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Department> AbpDepartment { get; set; }
        public DbSet<Department> Departments { get; set; }
        public LibrarySystemDbContext(DbContextOptions<LibrarySystemDbContext> options)
            : base(options)
        {
        }
    }
}
