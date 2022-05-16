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
    public int ProjectSchedleId { get; set; }
    public DateTime TaskDueDate { get; set; }
    public DateTime DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedOm { get; set; }
    public string CreatedBy { get; set; }
  }
}
