using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class Notes : INotes
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public bool IsPersoal { get; set; }

    public bool IsPublic { get; set; }

    
    
  
    public DateTime DateUpdated { get; set; }
    
    public DateTime CreatedOn { get; set; }
    public string CreatedById { get; set; }


    //Relationships
    public int? ProjectId { get; set; }
    public Project Project { get; set; }

    public string UpdatedById { get; set; }
    public User UpdatedBy { get; set; }
  }
}
