using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class ProjectSchedle : IDataProjectSchedle
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public DateTime DateUpdated { get; set; }
   
    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }

    //Relashonship

    public Project Project { get; set; }
    public int ProjectId { get; set; }

    public User UpdatedBy { get; set; }
    public string UpdatedById { get; set; }
  }
}
