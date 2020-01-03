using R6Service.Interface;
using R6Service.Service;
using R6VAG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace R6VAG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayerService _playerService;

        public HomeController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            var model = new SearchModel();
            if (name != null)
            {
                model = _playerService.SearchPlayer<SearchModel>(name);
            }
            return View(model);
        }
    }
}