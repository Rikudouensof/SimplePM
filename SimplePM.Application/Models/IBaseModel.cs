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

  public interface IDataNotes : INotes, IBaseModel
  {

  }



  public interface IDataProject : IProject, IBaseModel
  {

  }

  public interface IDataProjectRoles : IProjectRoles, IBaseModel
  {

  }

  public interface IDataProjectSchedle : IProjectSchedle, IBaseModel
  {

  }

  

  public interface IDataProjectTasks : IProjectTasks, IBaseModel
  {

  }

  public interface IDataProjectUsers : IProjectUsers, IBaseModel
  {

  }

  public interface IDataTaskUsers : ITaskUsers, IBaseModel
  {

  }
}

