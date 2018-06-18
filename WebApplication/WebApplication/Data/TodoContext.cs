using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        private DbSet<ToDo> toDo;

        public DbSet<ToDo> ToDo { get => toDo; set => toDo = value; }
    }
}
