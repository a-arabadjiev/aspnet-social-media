namespace MySocialMediaApp.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Claims;

    using Microsoft.AspNetCore.Mvc;
    using MySocialMediaApp.Data;
    using MySocialMediaApp.Data.Common.Repositories;
    using MySocialMediaApp.Data.Models;
    using MySocialMediaApp.Services.Data;
    using MySocialMediaApp.Web.ViewModels;
    using MySocialMediaApp.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;

        public HomeController(IGetCountsService countsService)
        {
            this.countsService = countsService;
        }

        public IActionResult Index()
        {
            var viewModel = this.countsService.GetCounts();
            viewModel.UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
