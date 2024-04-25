using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectASP.NetcoreMVC.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
