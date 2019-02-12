using System;
using System.ComponentModel.DataAnnotations;

namespace Artisana.Models
{
    public class Artisans
    {
        public string Id { get; set; }
        
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		[Required]
		public string FirstName { get; set; }
		
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
		[Required]
		public string LastName { get; set; }
		
		[Required]
		public string Occupation { get; set; }
		
		[Required]
		public string Gender { get; set; }
		
		[Required]
		public string Rating { get; set; }
		
		[Required]
		public string Avatar { get; set; }
        
		[Display(Name = "Upload Date")]
		[DataType(DataType.Date)]
        public DateTime DateAdded{ get; set; }
    }
}