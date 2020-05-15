using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadPicture.Models;

namespace UploadPicture.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Movie> Movie { get; set; }
       
      

       

      




    }
}
