using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Parceldetailsdbcontext:DbContext
    {
        public Parceldetailsdbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Parceldetails> parceldetails { get; set; }
    }
}
