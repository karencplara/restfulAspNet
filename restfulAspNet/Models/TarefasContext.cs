﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace restfulAspNet.Models
{
    public class TarefasContext: DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set;}
    }
}