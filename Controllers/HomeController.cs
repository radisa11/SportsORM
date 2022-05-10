using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();

                ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Womens"))
                .ToList();ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => !l.Sport.Contains("Footbal"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Teams
                .OrderByDescending(n => n.Location)
                .ToList();ViewBag.BaseballLeagues = _context.Teams
                .OrderBy(n => n.TeamName)
                .ToList();
                ViewBag.BaseballLeagues = _context.Players
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Players
                .Where(l => l.FirstName.Contains("Joshua"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Players
                .Where(l => l.LastName.Contains("Cooper")).Where(l => !l.FirstName.Contains("Joshua"))
                .ToList();
                ViewBag.BaseballLeagues = _context.Players
                .Where(l => l.FirstName.Contains("Alexander")).Where(l => l.FirstName.Contains("Wyatt"))
                .ToList();
                
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}