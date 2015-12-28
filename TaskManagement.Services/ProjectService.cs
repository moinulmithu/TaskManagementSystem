using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.ViewModel;
using TaskManagementDAL;

namespace TaskManagement.Services
{
    public class ProjectService
    {
        public List<ProjectViewModel> GetAll()
        {
            TaskManagementDbEntities db = new TaskManagementDbEntities();
            IQueryable<Project> dbSet = db.Projects.AsQueryable();
            List<ProjectViewModel> list = dbSet.Select(x => new ProjectViewModel() {Id = x.Id, Name = x.Name, Count = x.Count}).ToList();
            return list;
        } 
    }
}
