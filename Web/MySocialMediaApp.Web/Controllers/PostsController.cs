namespace MySocialMediaApp.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using MySocialMediaApp.Web.ViewModels;

    public class PostsController : BaseController
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
