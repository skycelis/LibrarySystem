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
        //public virtual DbSet<Department> GetDepartments()
        //{
        //    return departments;
        //}

        ///* Define a DbSet for each entity of the application */
        //public virtual void SetDepartments(DbSet<Department> value)
        //{
        //    departments = value;
        //}

        public LibrarySystemDbContext(DbContextOptions<LibrarySystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Author> Authors { get; set; }  

    }
}
