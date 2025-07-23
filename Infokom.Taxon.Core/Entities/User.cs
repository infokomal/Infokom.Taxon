using Infokom.Taxon.Core.Atomics;
using System.ComponentModel.DataAnnotations;

namespace Infokom.Taxon.Core.Entities
{
	public class User
	{
		[Key]
		public Guid Id { get; set; }

		[Required, StringLength(64, MinimumLength = 4)]
		public string Username { get; set; }

		[StringLength(256)]
		public string PasswordHash { get; set; }
		
		[StringLength(32)]
		public string Prename { get; set; }

		[StringLength(32)]
		public string Midname { get; set; }

		[StringLength(32)]
		public string Surname { get; set; }
		
		public DateOnly? BirthDate { get; set; }
		
		[StringLength(64)]
		public string BirthPlace { get; set; }

		[StringLength(16)]
		public string Citizenship { get; set; }

		[StringLength(16)]
		public string CitizenId { get; set; }

		[StringLength(16)]
		public string Phone { get; set; }

		[StringLength(320)]
		public string Email { get; set; }

		[StringLength(256)]
		public string Address { get; set; }



		public Role Type { get; set; }
	}

}
