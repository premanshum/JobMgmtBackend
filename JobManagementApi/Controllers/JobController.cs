using JobManagementApi.Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JobManagementApi.Controllers
{
	[Authorize(Policy = "Job")]
	[ApiController]
	[Route("[controller]")]
	public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
		}

		[HttpGet]
		[Route("get1")]
		public IEnumerable<Job> Get1()
		{
			var jobs = new List<Job>()
			{
				new Job
				{
					CustomerName = "Jesse",
					JobId = "110",
					CustomerPhone = "988770020"
				},
				new Job
				{
					CustomerName = "Badger",
					JobId = "111",
					CustomerPhone = "9850900020"
				},
				new Job
				{
					CustomerName = "Skinny Pete",
					JobId = "112",
					CustomerPhone = "981129080"
				},
				new Job
				{
					CustomerName = "Mojo",
					JobId = "113",
					CustomerPhone = "988770020"
				}
			};

			return jobs;
		}

		[Authorize(Policy = "JobCreate")]
		[Route("create")]
		[HttpGet]
		public string Create()
		{
			return "Job created successfully";
		}


	}
}