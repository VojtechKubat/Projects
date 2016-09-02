using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using GameServer.Models;

namespace GameServer.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var c = new Character();
			c.Name = "Hello world!";
			c.Item = "Item no. 1";

			Console.WriteLine(">>> new item is {0}", c.Item);

			//return View(c);
			return View(c);
		}

		public IActionResult Create(string NewItem)
		{
			var c = new Character();
			c.Name = "BBBBBB";
			c.Item = NewItem;

			Console.WriteLine(">>> new item is {0}", NewItem);

			return View("Index", c);
		}
	}
}
