using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace aspPractice.Models
{
    public class MyDBContext
    {
            public MyDBContext()
            {

            }
            public DbSet<Problem> Problems { get; set; } // My domain models
            public DbSet<Subject> Subjects { get; set; }// My domain models
    }
}