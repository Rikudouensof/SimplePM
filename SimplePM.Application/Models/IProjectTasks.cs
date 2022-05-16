using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IProjectTasks : IBaseModel
  {
    public int Id { get; set; }

    public int ProjectSchedleId { get; set; }

    public DateTime TaskDueDate { get; set; }

  }
}
