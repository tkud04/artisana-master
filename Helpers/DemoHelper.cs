using System;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Artisana.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;


namespace Artisana.Helpers
{
    public class DemoHelper : IDemoHelper
    {	
		
		public string getRole(string email)
		{
			string ret = "NoRole";
		
			return ret;
		}
	}
}