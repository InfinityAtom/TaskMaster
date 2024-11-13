﻿// Models/TaskItem.cs
using System;

namespace TaskMaster.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
