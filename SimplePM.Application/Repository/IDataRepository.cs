using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Repository
{
  public interface INoteRepository
  {

    public IDataNotes GetOne(int id);

    public IDataNotes Add(IDataNotes data);

    public IDataNotes Edit(IDataNotes data);

    public IEnumerable<IDataNotes> GetAll();

    public bool Delete(int id);
  }

  public interface IProjectRepository
  {
    public IDataProject GetOne(int id);

    public IDataProject Add(IDataProject data);

    public IDataProject Edit(IDataProject data);

    public IEnumerable<IDataProject> GetAll();

    public bool Delete(int id);
  }

  public interface IProjectRolesRepository
  {
    public IDataProjectRoles GetOne(int id);

    public IDataProjectRoles Add(IDataProjectRoles data);

    public IDataProjectRoles Edit(IDataProjectRoles data);

    public IEnumerable<IDataProjectRoles> GetAll();

    public bool Delete(int id);
  }

  public interface IProjectSchedleRepository
  {
    public IDataProjectSchedle GetOne(int id);

    public IDataProjectSchedle Add(IDataProjectSchedle data);

    public IDataProjectSchedle Edit(IDataProjectSchedle data);

    public IEnumerable<IDataProjectSchedle> GetAll();

    public bool Delete(int id);
  }

  public interface IProjectTaskRepository
  {
    public IDataProjectTasks GetOne(int id);

    public IDataProjectTasks Add(IDataProjectTasks data);

    public IDataProjectTasks Edit(IDataProjectTasks data);

    public IEnumerable<IDataProjectTasks> GetAll();

    public bool Delete(int id);
  }

  public interface IProjectUsersRepository
  {
    public IDataProjectUsers GetOne(int id);

    public IDataProjectUsers Add(IDataProjectUsers data);

    public IDataProjectUsers Edit(IDataProjectUsers data);

    public IEnumerable<IDataProjectUsers> GetAll();

    public bool Delete(int id);
  }

  public interface ITaskUsersRepository
  {
    public IDataTaskUsers GetOne(int id);

    public IDataTaskUsers Add(IDataTaskUsers data);

    public IDataTaskUsers Edit(IDataTaskUsers data);

    public IEnumerable<IDataTaskUsers> GetAll();

    public bool Delete(int id);
  }

 
}
