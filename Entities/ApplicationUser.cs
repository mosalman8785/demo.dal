using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.dal.Entities
{
    public class ApplicationUser: IdentityUser//i can use IdentityUser but if  i want to add any property so i make this class(ApplicationUser) and i use this class in calling
    {
        public bool IsActive { get; set; }
    }
}
