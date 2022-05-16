using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class TaskUsers : ITaskUsers
  {
    public int Id { get; set; }
    public string MemberId { get; set; }


    
    public DateTime DateUpdated { get; set; }
   
    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }

    //Relationship
    public ProjectTasks ProjectTask { get; set; }
    public int ProjectTaskId { get; set; }

    public User UpdatedBy { get; set; }
    public string UpdatedById { get; set; }

  }
}
