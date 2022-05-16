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

     string UpdatedBy { get; set; }

     DateTime CreatedOm { get; set; }

     string CreatedBy { get; set; }
  }
}
