using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class ProjectRoles : IProjectRoles
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProjectId { get; set; }
    public DateTime DateUpdated { get; set; }
  

    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }



    //Relationship
    public User UpdatedBy { get; set; }
    public string UpdatedById { get; set; }
  }
}