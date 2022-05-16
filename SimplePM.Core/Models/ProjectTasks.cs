using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class ProjectTasks : IProjectTasks
  {
    public int Id { get; set; }
    


    public DateTime TaskDueDate { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }

    //Relationship

    public ProjectSchedle ProjectSchedle { get; set; }
    public int ProjectSchedleId { get; set; }

    public User UpdatedBy { get; set; }
    public string UpdatedById { get; set; }
  }
}
