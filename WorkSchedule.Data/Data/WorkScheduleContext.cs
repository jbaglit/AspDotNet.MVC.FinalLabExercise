﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.Data
{
    public class WorkScheduleContext : DbContext
    {
        public WorkScheduleContext(DbContextOptions<WorkScheduleContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PlacementContract> PlacementContracts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=2MMBQG3;Database=OperaDB;User Id=sa;Password=password");
            }
        }
    }
}
