using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IBaseModel
  {

     DateTime DateUpdated { get; set; }

     string UpdatedById { get; set; }

     DateTime CreatedOn { get; set; }

     string CreatedById { get; set; }
  }
}
