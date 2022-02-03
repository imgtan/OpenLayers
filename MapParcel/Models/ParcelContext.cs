using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MapParcel_son.Models
{
    public class ParcelContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ParcelContext()
        {
        }

        public ParcelContext(DbContextOptions<ParcelContext> options) : base(options) { }
        public Microsoft.EntityFrameworkCore.DbSet<ParcelModel> Parcels { get; set; }
    }
}
