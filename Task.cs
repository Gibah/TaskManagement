using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(int id, string description) 
        {
            Id = id;
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Id} : {Description}";
        }
    }
}
