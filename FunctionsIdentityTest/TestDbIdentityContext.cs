using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FunctionsIdentityTest
{
	public class TestDbIdentityContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
	{
		public TestDbIdentityContext(DbContextOptions<TestDbIdentityContext> options)
			: base(options)
		{

		}
	}

	public class ApplicationUser : IdentityUser<int>
	{
	}

	public class ApplicationRole : IdentityRole<int>
	{
		public ApplicationRole(string name) : base(name)
		{
		}
	}
}
