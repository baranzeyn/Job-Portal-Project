using Microsoft.AspNetCore.Mvc;

namespace Job_Portal_Project.Components
{
    public class JobFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {

            return View();
        }
    }
}