using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunalServices.Domain.Entities
{
	public class Abonent
	{
        public int AbonentId { get; set; }
		public string Login { get; set; }
		private string hashedPassword;
		[JsonIgnore]
		public string Password 
		{
			get { return hashedPassword; }
			set { hashedPassword = HashPassword(value); }
		}
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsValidPassword(string password)
		{
			return Password == HashPassword(password);
		}
		private string HashPassword(string password)
		{
			return password;
		}
	}
