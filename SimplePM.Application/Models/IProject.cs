using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IProject 
  {
    public int Id { get; set; }

    public int Title { get; set; }


    public string Description { get; set; }

    public string ImageUrl { get; set; }

  }
}
