using SimplePM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Services
{
  public interface INoteRepository
  {

    public INotes GetOne(int id);

    public INotes Add(INotes data);

    public INotes Edit(INotes data);

    public IEnumerable<INotes> GetAll();

    public bool Delete(int id);


    public IDataNotes MgtGetOne(int id);

    public IDataNotes MgtAdd(IDataNotes data);

    public IDataNotes MgtEdit(IDataNotes data);

    public IEnumerable<IDataNotes> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface IProjectRepository
  {
    public IProject GetOne(int id);

    public IProject Add(IProject data);

    public IProject Edit(IProject data);

    public IEnumerable<IProject> GetAll();

    public bool Delete(int id);


    public IDataProject MgtGetOne(int id);

    public IDataProject MgtAdd(IDataProject data);

    public IDataProject MgtEdit(IDataProject data);

    public IEnumerable<IDataProject> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface IProjectRolesRepository
  {
    public IProjectRoles GetOne(int id);

    public IProjectRoles Add(IProjectRoles data);

    public IProjectRoles Edit(IProjectRoles data);

    public IEnumerable<IProjectRoles> GetAll();

    public bool Delete(int id);



    public IDataProjectRoles MgtGetOne(int id);

    public IDataProjectRoles MgtAdd(IDataProjectRoles data);

    public IDataProjectRoles MgtEdit(IDataProjectRoles data);

    public IEnumerable<IDataProjectRoles> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface IProjectSchedleRepository
  {
    public IProjectSchedle GetOne(int id);

    public IProjectSchedle Add(IProjectSchedle data);

    public IProjectSchedle Edit(IProjectSchedle data);

    public IEnumerable<IProjectSchedle> GetAll();

    public bool Delete(int id);




    public IDataProjectSchedle MgtGetOne(int id);

    public IDataProjectSchedle MgtAdd(IDataProjectSchedle data);

    public IDataProjectSchedle MgtEdit(IDataProjectSchedle data);

    public IEnumerable<IDataProjectSchedle> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface IProjectTaskRepository
  {
    public IProjectTasks GetOne(int id);

    public IProjectTasks Add(IProjectTasks data);

    public IProjectTasks Edit(IProjectTasks data);

    public IEnumerable<IProjectTasks> GetAll();

    public bool Delete(int id);





    public IDataProjectTasks MgtGetOne(int id);

    public IDataProjectTasks MgtAdd(IDataProjectTasks data);

    public IDataProjectTasks MgtEdit(IDataProjectTasks data);

    public IEnumerable<IDataProjectTasks> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface IProjectUsersRepository
  {
    public IProjectUsers GetOne(int id);

    public IProjectUsers Add(IProjectUsers data);

    public IProjectUsers Edit(IProjectUsers data);

    public IEnumerable<IProjectUsers> GetAll();

    public bool Delete(int id);






    public IDataProjectUsers MgtGetOne(int id);

    public IDataProjectUsers MgtAdd(IDataProjectUsers data);

    public IDataProjectUsers MgtEdit(IDataProjectUsers data);

    public IEnumerable<IDataProjectUsers> MgtGetAll();

    public bool MgtDelete(int id);
  }

  public interface ITaskUsersRepository
  {
    public ITaskUsers GetOne(int id);

    public ITaskUsers Add(ITaskUsers data);

    public ITaskUsers Edit(ITaskUsers data);

    public IEnumerable<ITaskUsers> GetAll();

    public bool Delete(int id);



    public IDataTaskUsers MgtGetOne(int id);

    public IDataTaskUsers MgtAdd(IDataTaskUsers data);

    public IDataTaskUsers MgtEdit(IDataTaskUsers data);

    public IEnumerable<IDataTaskUsers> MgtGetAll();

    public bool MgtDelete(int id);
  }
}
