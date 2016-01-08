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
    public class TaskController : ApiController
    {
        TaskService service = new TaskService();

        public ResponseModel Get()
        {

            ResponseModel response;
            try
            {
                List<TaskViewModel> Tasks = service.GetAll();
                response = new ResponseModel(Tasks);
            }
            catch (Exception)
            {

                response = new ResponseModel(null, false, "Error occured!");
            }
            return response;
        }

        public ResponseModel Post(Task task)
        {
            ResponseModel response;
            try
            {
                task.Project = null;
                int id = service.Save(task);
                response = id > 0 ? new ResponseModel(id) : new ResponseModel(null, false, "Coudn't Save");
            }
            catch (Exception)
            {

                response = new ResponseModel(null, false, "Error occured!");
            }
            return response;
        }
    }
}
