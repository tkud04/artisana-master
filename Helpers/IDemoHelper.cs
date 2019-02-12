using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Artisana.Models;
using System.Collections.Generic;
using System.Linq;

namespace Artisana.Helpers
{
    public interface IDemoHelper
    {
		string getRole(string email);
    }
}