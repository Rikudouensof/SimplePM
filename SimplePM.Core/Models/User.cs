using Microsoft.AspNetCore.Identity;
using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class User : IdentityUser, IUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateJoined { get; set; }
    public DateTime LastOnline { get; set; }

    public string imageUrl { get; set; }
  }
}
