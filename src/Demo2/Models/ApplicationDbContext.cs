using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo2.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Demo2.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
    }
}
