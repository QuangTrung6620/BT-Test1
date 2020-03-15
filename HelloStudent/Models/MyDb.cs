using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloStudent.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("MyConnectionString")
        {
        }

        public System.Data.Entity.DbSet<HelloStudent.Models.Student> Students { get; set; }
    }
}