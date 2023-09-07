using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace prviProjekat_2_.Models

{
	public class Expences
	{
        [Key]
        public int Id { get; set; }

		[DisplayName("Expence")]
		[Required]
        public string ExpenceName { get; set; }

		[Required]
		[Range(1,int.MaxValue, ErrorMessage ="Amount must be greather than zero.")]
		public int Amount { get; set; }
	}
}
