using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSV_Manipulator.Models;
using System.IO;

namespace CSV_Manipulator.Controllers
{
	public class ApiController : Controller
	{
		private readonly ILogger<ApiController> _logger;

		public ApiController(ILogger<ApiController> logger)
		{
			_logger = logger;
		}

		public IActionResult Save()
		{

			using (var reader = new StreamReader(Request.Body))
			{
				var body = reader.ReadToEnd();

				SaveModel file = new SaveModel {JsonString = body};

				file.OnSet();

			}
			return Ok("File was saved!");
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
