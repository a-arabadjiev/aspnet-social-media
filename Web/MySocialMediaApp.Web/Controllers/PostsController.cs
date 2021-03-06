﻿namespace MySocialMediaApp.Web.Controllers
{
    using System.Diagnostics;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using MySocialMediaApp.Data.Models;
    using MySocialMediaApp.Services.Data;
    using MySocialMediaApp.Web.ViewModels.Posts;

    public class PostsController : BaseController
    {
        private readonly IPostsService postsService;
        private readonly UserManager<ApplicationUser> userManager;

        public PostsController(IPostsService postsService, UserManager<ApplicationUser> userManager)
        {
            this.postsService = postsService;
            this.userManager = userManager;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreatePostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            input.CreatedByUserId = userId;

            await this.postsService.Create(input);

            return this.Redirect("/");
        }
    }
}
