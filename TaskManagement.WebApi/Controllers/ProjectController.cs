using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManagement.Services;
using TaskManagement.ViewModel;
using TaskManagementDAL;

namespace TaskManagement.WebApi.Controllers
{
    public class ProjectController : ApiController
    {
        ProjectService service = new ProjectService();

        public ResponseModel Get()
        {

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

        public ResponseModel Post(Project project)
        {
            ResponseModel response;
            try
            {
                int id = service.Save(project);
                response = id > 0 ? new ResponseModel(id) : new ResponseModel(null,false,"Coudn't Save");
            }
            catch (Exception)
            {

                response = new ResponseModel(null, false, "Error occured!");
            }
            return response;
        }

    }
}
