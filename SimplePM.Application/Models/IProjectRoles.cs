using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IProjectRoles : IBaseModel
  {

    public int Id { get; set; }

    public string Name { get; set; }

    public int ProjectId { get; set; }
  }
}
