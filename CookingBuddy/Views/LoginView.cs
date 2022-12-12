using System;
using System.ComponentModel.DataAnnotations;

namespace CookingBuddy.Views
{
	public class LoginView
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}

