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
        public ResponseModel Get()
        {
            ProjectService service = new ProjectService();
            ResponseModel response;
            try
            {
                List<ProjectViewModel> projects = service.GetAll();
                response = new ResponseModel(projects);
            }
            catch (Exception)
            {

                response = new ResponseModel(null, false, "Error occured!");
            }
            return response;
            
        }
    }
}
