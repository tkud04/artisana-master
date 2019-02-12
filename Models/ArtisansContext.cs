using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Artisana.Models
{
    public class ArtisansContext : DbContext
    {
        public ArtisansContext(DbContextOptions<ArtisansContext> options)
		     : base(options)
			 {
				 
			 }
		
		public DbSet<Artisana.Models.Artisans> Artisans {get; set;}
    }
}