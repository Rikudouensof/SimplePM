using SimplePM.Application.Models;
using SimplePM.Application.Repository;
using SimplePM.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Core.Repository
{
  public class NoteRepository : INoteRepository
  {
    private SimplePMDbContext _db;
    public NoteRepository(SimplePMDbContext db)
    {
      _db = db;
    }
    public IDataNotes Add(IDataNotes data)
    {
      _db.Notes.Add((Models.Notes)data);
      _db.SaveChanges();
      return data;

    }

    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.Notes.Where(x => x.Id == id).FirstOrDefault();
        _db.Notes.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {

      
      }
      return isSucessful;
    }

    public IDataNotes Edit(IDataNotes data)
    {
      _db.Notes.Update((Models.Notes)data);
      _db.SaveChanges();
      return data;
    }

    public IEnumerable<IDataNotes> GetAll()
    {
      var alldata = _db.Notes;
      return alldata;
    }

    public IDataNotes GetOne(int id)
    {
      var data = _db.Notes.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }



  public class ProjectRepository : IProjectRepository
  {
    private SimplePMDbContext _db;
    public ProjectRepository(SimplePMDbContext db)
    {
      _db = db;
    }



    public IDataProject Add(IDataProject data)
    {
      _db.Projects.Add((Models.Project)data);
      _db.SaveChanges();
      return data;
    }



    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.Projects.Where(x => x.Id == id).FirstOrDefault();
        _db.Projects.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }



    public IDataProject Edit(IDataProject data)
    {
      _db.Projects.Update((Models.Project)data);
      _db.SaveChanges();
      return data;
    }



    public IEnumerable<IDataProject> GetAll()
    {
      var alldata = _db.Projects;
      return alldata;
    }



    public IDataProject GetOne(int id)
    {
      var data = _db.Projects.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }



  public class ProjectRolesRepository : IProjectRolesRepository
  {
    private SimplePMDbContext _db;
    public ProjectRolesRepository(SimplePMDbContext db)
    {
      _db = db;
    }



    public IDataProjectRoles Add(IDataProjectRoles data)
    {
      _db.ProjectRoles.Add((Models.ProjectRoles)data);
      _db.SaveChanges();
      return data;
    }



    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.ProjectRoles.Where(x => x.Id == id).FirstOrDefault();
        _db.ProjectRoles.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }



    public IDataProjectRoles Edit(IDataProjectRoles data)
    {
      _db.ProjectRoles.Update((Models.ProjectRoles)data);
      _db.SaveChanges();
      return data;
    }



    public IEnumerable<IDataProjectRoles> GetAll()
    {
      var alldata = _db.ProjectRoles;
      return alldata;
    }



    public IDataProjectRoles GetOne(int id)
    {
      var data = _db.ProjectRoles.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }



  public class ProjectSchedleRepository : IProjectSchedleRepository
  {
    private SimplePMDbContext _db;
    public ProjectSchedleRepository(SimplePMDbContext db)
    {
      _db = db;
    }



    public IDataProjectSchedle Add(IDataProjectSchedle data)
    {
      _db.ProjectSchedles.Add((Models.ProjectSchedle)data);
      _db.SaveChanges();
      return data;
    }



    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.ProjectSchedles.Where(x => x.Id == id).FirstOrDefault();
        _db.ProjectSchedles.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }





    public IDataProjectSchedle Edit(IDataProjectSchedle data)
    {
      _db.ProjectSchedles.Update((Models.ProjectSchedle)data);
      _db.SaveChanges();
      return data;
    }



    public IEnumerable<IDataProjectSchedle> GetAll()
    {
      var alldata = _db.ProjectSchedles;
      return alldata;
    }



    public IDataProjectSchedle GetOne(int id)
    {
      var data = _db.ProjectSchedles.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }
    


  public class ProjectTaskRepository : IProjectTaskRepository
  {
    private SimplePMDbContext _db;
    public ProjectTaskRepository(SimplePMDbContext db)
    {
      _db = db;
    }




    public IDataProjectTasks Add(IDataProjectTasks data)
    {
      _db.ProjectTasks.Add((Models.ProjectTasks)data);
      _db.SaveChanges();
      return data;
    }




    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.ProjectTasks.Where(x => x.Id == id).FirstOrDefault();
        _db.ProjectTasks.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }




    public IDataProjectTasks Edit(IDataProjectTasks data)
    {
      _db.ProjectTasks.Update((Models.ProjectTasks)data);
      _db.SaveChanges();
      return data;
    }



    public IEnumerable<IDataProjectTasks> GetAll()
    {
      var alldata = _db.ProjectTasks;
      return alldata;
    }



    public IDataProjectTasks GetOne(int id)
    {
      var data = _db.ProjectTasks.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }



  public class ProjectUsersRepository : IProjectUsersRepository
  {
    private SimplePMDbContext _db;


    public ProjectUsersRepository(SimplePMDbContext db)
    {
      _db = db;
    }




    public IDataProjectUsers Add(IDataProjectUsers data)
    {
      _db.ProjectUsers.Add((Models.ProjectUsers)data);
      _db.SaveChanges();
      return data;
    }




    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.ProjectUsers.Where(x => x.Id == id).FirstOrDefault();
        _db.ProjectUsers.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }





    public IDataProjectUsers Edit(IDataProjectUsers data)
    {
      _db.ProjectUsers.Update((Models.ProjectUsers)data);
      _db.SaveChanges();
      return data;
    }




    public IEnumerable<IDataProjectUsers> GetAll()
    {
      var alldata = _db.ProjectUsers;
      return alldata;
    }



    public IDataProjectUsers GetOne(int id)
    {
      var data = _db.ProjectUsers.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }





  public class TaskUsersRepository : ITaskUsersRepository
  {
    private readonly SimplePMDbContext _db;
    public TaskUsersRepository(SimplePMDbContext db)
    {
      _db = db;
    }



    public IDataTaskUsers Add(IDataTaskUsers data)
    {
      _db.TaskUsers.Add((Models.TaskUsers)data);
      _db.SaveChanges();
      return data;
    }




    public bool Delete(int id)
    {
      bool isSucessful = false;
      try
      {
        var dbData = _db.TaskUsers.Where(x => x.Id == id).FirstOrDefault();
        _db.TaskUsers.Remove(dbData);
        _db.SaveChanges();
        isSucessful = true;
      }
      catch
      {


      }
      return isSucessful;
    }




    public IDataTaskUsers Edit(IDataTaskUsers data)
    {
      _db.TaskUsers.Update((Models.TaskUsers)data);
      _db.SaveChanges();
      return data;
    }



    public IEnumerable<IDataTaskUsers> GetAll()
    {
      var alldata = _db.TaskUsers;
      return alldata;
    }



    public IDataTaskUsers GetOne(int id)
    {
      var data = _db.TaskUsers.Where(x => x.Id == id).FirstOrDefault();
      return data;
    }
  }
}
