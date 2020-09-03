using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(

                        new Employee
                        {
                            ID = 1,
                            Name = "Joseph",
                            Department = Dept.IT,
                            Email = "joseph@abahtech.ng"
                        },

                        new Employee
                        {
                            ID = 2,
                            Name = "Tosin",
                            Department = Dept.HR,
                            Email = "tosin@abahtech.ng"
                        }
                );

        }
    }
}
