using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface ISchedleUsers : IBaseModel
  {

    public int Id { get; set; }

    public string Member { get; set; }

    public int ProjectId { get; set; }

    public int ProjectRoleId { get; set; }
  }
}
