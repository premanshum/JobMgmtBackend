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
					Phone = "988770020",
					Status = "Pending"
				},
				new Job
				{
					CustomerName = "Badger",
					JobId = "111",
					Phone = "9850900020",
					Status = "Started"
				},
				new Job
				{
					CustomerName = "Skinny Pete",
					JobId = "112",
					Phone = "981129080",
					Status = "Cancelled"
				},
				new Job
				{
					CustomerName = "Mojo",
					JobId = "113",
					Phone = "988770020",
					Status = "Done"
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