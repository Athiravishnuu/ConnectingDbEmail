using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConnectingDbEmail.Db
{
    public class DemoDbContext:DbContext
    {


        public DbSet<Model.Email> Emails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var path = "Server=localhost\\SQLEXPRESS;Database=Emails;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
        }
    }

   
    
    
}
