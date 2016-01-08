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

        public int Save(Task Task)
        {
            
            TaskManagementDbEntities db = new TaskManagementDbEntities();
            //Task.CreatedDate = DateTime.Now;
            //Task.ChangedDate = DateTime.Now;
            Task added = db.Tasks.Add(entity: Task);
            db.SaveChanges();
            return added.Id;
        }
    }
}
