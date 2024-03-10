using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using SQLite;
namespace ToDoList.Models
{
    internal class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
