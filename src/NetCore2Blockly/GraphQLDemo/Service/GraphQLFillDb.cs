﻿using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Service
{
    public partial class GraphQLDbContext : DbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().
                HasData(new Department { Iddepartment = 1, Name = "IT" },
                new Department { Iddepartment = 2, Name = "Accounting" }
                );

            modelBuilder.Entity<Employee>().
                HasData(new Employee { Iddepartment = 1, Name = "Person from IT", Idemployee = 1 },
                new Employee { Iddepartment = 2, Name = "Person from Accounting", Idemployee = 2 }
                );


        }


    }
}
