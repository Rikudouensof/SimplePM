using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Models
{
  internal class ProjectUsers : IProjectUsers
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public int ProjectId { get; set; }
    public int ProjectRoleId { get; set; }
    public DateTime DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreatedOm { get; set; }
    public string CreatedBy { get; set; }
  }
}
