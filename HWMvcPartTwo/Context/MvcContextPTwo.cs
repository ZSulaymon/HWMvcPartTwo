using HWMvcPartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWMvcPartTwo.Context
{
    public class MvcContextPTwo : DbContext 
    {
        public MvcContextPTwo(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<Food> foods { get; set; }
    }
}
