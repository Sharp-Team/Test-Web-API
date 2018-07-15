using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class ToDo
    {
        private int id;
        private string title;
        private bool isDone;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}
