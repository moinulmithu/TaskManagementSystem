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

        public int Save(Project project)
        {
            TaskManagementDbEntities db = new TaskManagementDbEntities();
            project.CreatedDate = DateTime.Now;
            project.ChangedDate = DateTime.Now;
            Project added = db.Projects.Add(project);
            db.SaveChanges();
            return added.Id;
        }
    }

}
