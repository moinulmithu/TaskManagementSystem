using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManagement.ViewModel;

namespace TaskManagement.WebApi.Controllers
{
    public class ProjectController : ApiController
    {
        public List<ProjectViewModel> Get()
        {
            return new List<ProjectViewModel>() {new ProjectViewModel() {Id = 1, Name = "Test", Count = 0}};
        }
    }
}
