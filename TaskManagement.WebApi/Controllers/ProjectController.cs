using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManagement.Services;
using TaskManagement.ViewModel;

namespace TaskManagement.WebApi.Controllers
{
    public class ProjectController : ApiController
    {
        public List<ProjectViewModel> Get()
        {
            ProjectService service = new ProjectService();
            List<ProjectViewModel> projects = service.GetAll();
            return projects;
            
        }
    }
}
