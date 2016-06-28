using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["job_form"];
      Get["job_board"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View ["job_board.cshtml", allJobs];
      };
      Post["job_board"] = _ => {
        Job newJob = new Job
        (
        Request.Form["new-title"],
        Request.Form["new-description"],
        Request.Form["new-contact"]
        );
        newJob.Save();
        return View ["job_board.cshtml", newJob];
      };
    }
  }
}
