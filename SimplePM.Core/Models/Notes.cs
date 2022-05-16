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

    public int? ProjectId { get; set; }
    public DateTime DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedOm { get; set; }
    public string CreatedBy { get; set; }
  }
}
