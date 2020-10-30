using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace QualificationsAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        public List<Subject> Subjects { get; set; }
    }
}
