using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Data.Common;

namespace OLprojekt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Guild {  get; set; }
        public int Xp { get; set; }

        

    }
}