using System;
using System.Collections.Generic;
using System.Text;
using DotNetCoreCrud.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreCrud.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EmployeeOne> EmployeeOne { get; set; }
    }
}
