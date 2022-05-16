using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface ITaskUsers 
  {

    public int Id { get; set; }

    public string MemberId { get; set; }

    public int ProjectTaskId { get; set; }

  }
}
