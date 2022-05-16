using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IUser
  {
     string Id { get; set; }

     string FirstName { get; set; }

     string LastName { get; set; }

     string MiddleName { get; set; }

     string UserName { get; set; }

     string Email { get; set; }


     DateTime DateJoined { get; set; }

     DateTime LastOnline { get; set; }


     string imageUrl { get; set; }



  }
}
