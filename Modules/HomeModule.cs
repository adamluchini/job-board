using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["job_form.cshtml"];
      Post["/job_board"] = _ => {
        List<JobOpening> allJobs = JobOpening.GetAll();
        JobOpening newJobOpening = new JobOpening
        (
        Request.Form["new-title"],
        Request.Form["new-description"],
        Request.Form["new-contact"]
        );
        newJobOpening.Save();
        return View ["job_board.cshtml", allJobs];
      };
    }
  }
}
