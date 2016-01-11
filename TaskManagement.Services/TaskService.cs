using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagement.ViewModel;
using TaskManagementDAL;


namespace TaskManagement.Services
{
    public class TaskService
    {
        public List<TaskViewModel> GetAll()
        {
            TaskManagementDbEntities db = new TaskManagementDbEntities();
            IQueryable<Task> dbSet = db.Tasks.AsQueryable();
            List<TaskViewModel> list = dbSet.Select(x => new TaskViewModel() { Id = x.Id, Name = x.Name}).ToList();
            return list;
        }

        public int Save(Task task)
        {
            
            TaskManagementDbEntities db = new TaskManagementDbEntities();
            task.Created = DateTime.Now;
            task.Changed = DateTime.Now;
            Task added = db.Tasks.Add(entity: task);
            db.SaveChanges();
            return added.Id;
        }
    }
}
