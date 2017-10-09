using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CQLFileRepository.Models;

namespace CQLFileRepository.Controllers
{
	public class HomeController : Controller
	{
		[Authorize]
		public ActionResult Index(FileRepositoryModels model)
		{
			model.filePath = Server.MapPath(model.relativePath ?? @"~/Files");
			model.relativePath = string.Format(@"{0}\", model.relativePath ?? @"Files");
            ViewBag.Message = @"<a href=""http://www.yahoo.com""> Click me </a>"; // model.relativePath;

			return View(model);
		}
	}
}
