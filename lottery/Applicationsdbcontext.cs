using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lottery
{
    
    class Applicationsdbcontext:DbContext
    {
        public DbSet  <User> users{ get; set; }
        public Applicationsdbcontext():base()
        {
          
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseMySQL("server=localhost;database=lottery;uid=root;pwd=;");
        }
    }
}
