using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class ProjectUsers : IDataProjectUsers
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    
   
    public DateTime DateUpdated { get; set; }
    
    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }

    //Relationship

    public Project Project { get; set; }
    public int ProjectId { get; set; }


    public ProjectRoles ProjectRole { get; set; }
    public int ProjectRoleId { get; set; }

    public User UpdatedBy { get; set; }
    public string UpdatedById { get; set; }


  }
}
