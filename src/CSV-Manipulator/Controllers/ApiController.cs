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

			// Create the instance for the stream reader object
			using (var reader = new StreamReader(Request.Body))
			{
				// read the stream and store it
				var body = reader.ReadToEnd();

				// instantiate the save model and assign to his property JsonString the value of body
				SaveModel file = new SaveModel {JsonString = body};

				// run saving method
				file.OnSet();

			}
			// return the ok status
			return Ok("File was saved!");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
