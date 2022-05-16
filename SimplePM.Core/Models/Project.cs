using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  public class Project : IProject
  {
    public int Id { get; set; }
    public int Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedOm { get; set; }
    public string CreatedBy { get; set; }
  }
}
