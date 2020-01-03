using R6Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using R6VAG.Model;

namespace R6VAG.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpGet]
        public ActionResult Index(string id)
        {
            var model = new PlayerProfileModel();
            if (id != null)
            {
                model = _playerService.GetPlayerProfile<PlayerProfileModel>(id);
            }
            return View(model);
        }
    }
}