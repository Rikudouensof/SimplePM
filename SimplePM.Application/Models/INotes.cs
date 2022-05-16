using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface INotes 
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public bool IsPersoal { get; set; }

    public bool IsPublic { get; set; }

    public int? ProjectId { get; set; }
  }
}
