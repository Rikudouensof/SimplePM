﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Application.Models
{
  public interface IProjectUsers : IBaseModel
  {

    public int Id { get; set; }

    public string UserId { get; set; }

    public int ProjectId { get; set; }

    public int ProjectRoleId { get; set; }
  }
}
